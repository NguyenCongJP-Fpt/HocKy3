using AppMusic_AssimentUWP_2.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppMusic_AssimentUWP_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        private Member currentMember;
        private static StorageFile file;
        private static string UploadUrl;
        private static string API_LOGIN = "http://2-dot-backup-server-002.appspot.com/_api/v2/members/authentication";


        public MainPage()
        {
            GetUploadUrl();
            this.currentMember = new Member();
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FontSize = 20;
            if (Home.IsSelected)
            {
                ResultTextBlock.Text = "Trang Chủ";
            }
            else if (MyAccount.IsSelected)
            {
                ResultTextBlock.Text = "Tài Khoản Của Tôi";
            }
            else if (MyVideo.IsSelected)
            {
                ResultTextBlock.Text = "Video Của Tôi";
            }
            else if (MyMusic.IsSelected)
            {
                ResultTextBlock.Text = "Bài Hát Của Tôi";
            }
            else if (Listened.IsSelected)
            {
                ResultTextBlock.Text = "Nghe Gần Đây";
            }
            else if (ListMusic.IsSelected)
            {
                ResultTextBlock.Text = "Danh Sách Bài Hát";
            }
            else if (Favorites.IsSelected)
            {
                ResultTextBlock.Text = "BH Yêu Thích";
            }
            else if (Setting.IsSelected)
            {
                ResultTextBlock.Text = "Cài Đặt";
            }
        }

        //private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        //{

        //}

        private async void ShowLogin(object sender, RoutedEventArgs e)
        {
            var stackPanel = new StackPanel();
            var textBoxName = new TextBox
            {
                Header = "Email",
                Name = "Email",
                Margin = new Thickness(0, 5, 0, 10)
            };
            var textBoxPass = new PasswordBox
            {
                Header = "Password",
                Name = "Password",
            };
            stackPanel.Children.Add(textBoxName);
            stackPanel.Children.Add(textBoxPass);
            ContentDialog loginDialog = new ContentDialog()
            {
                Title = "Đăng Nhập",
                MaxWidth = this.ActualWidth,
                PrimaryButtonText = "Đăng Nhập",
                Content = stackPanel,
                CloseButtonText = "Cancel",

            };
            loginDialog.PrimaryButtonClick += LoginDialog_PrimaryButtonClick;

            await loginDialog.ShowAsync();
        }

        private void LoginDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Dictionary<String, String> LoginInfor = new Dictionary<string, string>();
            LoginInfor.Add("email", this.Email.Text);
            LoginInfor.Add("password", this.Password.Password);

            // Lay token
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(LoginInfor), System.Text.Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync(API_LOGIN, content).Result;
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                // save file...
                Debug.WriteLine(responseContent);
                // Doc token
                TokenResponse token = JsonConvert.DeserializeObject<TokenResponse>(responseContent);

                // Luu token
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile file = await folder.CreateFileAsync("token.txt", CreationCollisionOption.ReplaceExisting);
                await FileIO.WriteTextAsync(file, responseContent);

                // Lay thong tin ca nhan bang token.
                HttpClient client2 = new HttpClient();
                client2.DefaultRequestHeaders.Add("Authorization", "Basic " + token.token);
                var resp = client2.GetAsync("http://2-dot-backup-server-002.appspot.com/_api/v2/members/information").Result;
                Debug.WriteLine(await resp.Content.ReadAsStringAsync());
            }
            else
            {
                // Xu ly loi.
                ErrorResponse errorObject = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                if (errorObject != null && errorObject.error.Count > 0)
                {
                    foreach (var key in errorObject.error.Keys)
                    {
                        var textMessage = this.FindName(key);
                        if (textMessage == null)
                        {
                            continue;
                        }
                        TextBlock textBlock = textMessage as TextBlock;
                        textBlock.Text = errorObject.error[key];
                        textBlock.Visibility = Visibility.Visible;
                    }
                }
            }
        }

        private async void ShowRegister(object sender, RoutedEventArgs e)
        {
            var stackPanel = new StackPanel();
            var emailBox = new TextBox
            {
                Header = "Email",
                Name = "Email",
                Margin = new Thickness(0, 5, 0, 10)
            };
            var passBox = new PasswordBox
            {
                Header = "Mật Khẩu",
                Name = "Password",
            };
            var firstNameBox = new TextBox
            {
                Header = "First Name",
                Name = "FirstName",
                Margin = new Thickness(0, 10, 0, 0)
            };
            var lastNameBox = new TextBox
            {
                Header = "Last Name",
                Name = "LastName",
                Margin = new Thickness(0, 10, 0, 0)
            };
            var birthDayBox = new CalendarDatePicker
            {
                Header = "Birthday",
                Name = "Birthday",
                Margin = new Thickness(0, 10, 0, 0)
            };
            birthDayBox.DateChanged += BirthDay_DateChanged;

            //Tao ham gioi tinh
            var genderBlock = new TextBlock
            {
                Text = "Giới Tính",
                Margin = new Thickness(0, 10, 0, 0)
            };
            var stackpanelGender = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };
            var male = new RadioButton
            {
                Content = "Nam",
                Tag = 1
            };
            var female = new RadioButton
            {
                Content = "Nữ",
                Tag = 0
            };
            var other = new RadioButton
            {
                Content = "Khác",
                Tag = 2
            };
            stackpanelGender.Children.Add(male);
            stackpanelGender.Children.Add(female);
            stackpanelGender.Children.Add(other);
            male.Checked += Gender_Checked;
            female.Checked += Gender_Checked;
            other.Checked += Gender_Checked;

            var addressBox = new TextBox
            {
                Header = "Địa Chỉ",
                Name = "Address",
                AcceptsReturn = true,
                Height = 60,
                Margin = new Thickness(0, 10, 0, 0)
            };

            var introductionBox = new TextBox
            {
                Header = "Giới Thiệu",
                Name = "Introduction",
                AcceptsReturn = true,
                Height = 60,
                Margin = new Thickness(0, 10, 0, 0)
            };

            var captureBox = new Button
            {
                Content = "Chụp Ảnh",
                Name = "MyAvatar",
                Margin = new Thickness(0, 10, 0, 0)
            };
            captureBox.Click += CaptureBox_Click;

            var imageAvatar = new Image
            {
                Name = "MyAvatar",
                Margin = new Thickness(0, 10, 0, 0),
                Width = 140,
                Height = 140
            };

            var urlImageBox = new TextBox
            {
                Header = "Url Ảnh",
                Name = "ImageUrl",
                Text = "",
                Margin = new Thickness(0, 10, 0, 0)
            };

            var scrollViewer = new ScrollViewer
            {
                Content = stackPanel
            };

            //Add cac ham ow tren
            stackPanel.Children.Add(emailBox);
            stackPanel.Children.Add(passBox);
            stackPanel.Children.Add(firstNameBox);
            stackPanel.Children.Add(lastNameBox);
            stackPanel.Children.Add(genderBlock);
            stackPanel.Children.Add(stackpanelGender);
            stackPanel.Children.Add(birthDayBox);
            stackPanel.Children.Add(addressBox);
            stackPanel.Children.Add(introductionBox);
            stackPanel.Children.Add(captureBox);
            stackPanel.Children.Add(imageAvatar);
            stackPanel.Children.Add(urlImageBox);
            ContentDialog registerDialog = new ContentDialog()
            {
                Title = "Đăng Ký",
                MaxWidth = this.ActualWidth,
                PrimaryButtonText = "Đăng Ký",
                Content = scrollViewer,
                CloseButtonText = "Cancel",
            };

            await registerDialog.ShowAsync();

        }

        private async void CaptureBox_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);
            file = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);
            if (file == null)
            {
                // User cancelled photo capture
                return;
            }
            HttpUploadFile(UploadUrl, "myFile", "image/png");
        }

        private static async void GetUploadUrl()
        {
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
            Uri requestUri = new Uri("https://2-dot-backup-server-002.appspot.com/get-upload-token");
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            string httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(requestUri);
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }
            Debug.WriteLine(httpResponseBody);
            UploadUrl = httpResponseBody;
        }

        public async void HttpUploadFile(string url, string paramName, string contentType)
        {
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";

            Stream rs = await wr.GetRequestStreamAsync();
            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string header = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", paramName, "path_file", contentType);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

            // write file.
            Stream fileStream = await file.OpenStreamForReadAsync();
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);

            WebResponse wresp = null;
            try
            {
                wresp = await wr.GetResponseAsync();
                Stream stream2 = wresp.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
                //Debug.WriteLine(string.Format("File uploaded, server response is: @{0}@", reader2.ReadToEnd()));
                //string imgUrl = reader2.ReadToEnd();
                Uri u = new Uri(reader2.ReadToEnd(), UriKind.Absolute);
                Debug.WriteLine(u.AbsoluteUri);
                //ImageUrl.Text = u.AbsoluteUri;
                //MyAvatar.Source = new BitmapImage(u);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error uploading file", ex.StackTrace);
                Debug.WriteLine("Error uploading file", ex.InnerException);
                if (wresp != null)
                {
                    wresp = null;
                }
            }
            finally
            {
                wr = null;
            }
        }

        private void Gender_Checked(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("chon gioi tinh");
        }

        private void BirthDay_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            Debug.WriteLine("ngay sinh");
        }
    }
}
