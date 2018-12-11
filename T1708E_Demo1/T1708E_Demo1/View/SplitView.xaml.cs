using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1708E_Demo1.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitView : Page
    {
        public SplitView()
        {
            this.InitializeComponent();
        }

        private void btn_SplitView(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen = !this.MySplitView.IsPaneOpen;
        }

        private void btn_Frame(object sender, RoutedEventArgs e)
        {
            this.MyFrame.Navigate(typeof(LoginForm));
        }

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

            await loginDialog.ShowAsync();
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
                Content = "Chọn Ảnh",
                Name = "Introduction",
                Margin = new Thickness(0,10,0,0)
            };
            captureBox.Click += CaptureBox_Click;

            var imageAvatar = new Image
            {
                Name = "MyAvatar",
                Margin = new Thickness(0,10,0,0),
                Width = 140,
                Height = 140
            };

            var urlImageBox = new TextBox
            {
                Header = "Url Ảnh",
                Name = "ImageUrl",
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
            ContentDialog dialog = new ContentDialog()
            {
                Title = "Đăng Ký",
                MaxWidth = this.ActualWidth,
                PrimaryButtonText = "Đăng Ký",
                Content = scrollViewer,
                CloseButtonText = "Cancel",
            };

            await dialog.ShowAsync();

        }

        private void CaptureBox_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Test chon anh");
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
