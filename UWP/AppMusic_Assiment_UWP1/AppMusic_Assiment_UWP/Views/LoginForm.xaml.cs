using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace AppMusic_Assiment_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginForm : Page
    {
        //API_LOGIN là link Api đăng nhập.
        private static String API_LOGIN = "https://2-dot-backup-server-002.appspot.com/_api/v2/members/authentication";

        public LoginForm()
        {
            this.InitializeComponent();
        }

        //Gán sự kiện click nút Login.
        private async void btn_Login(object sender, RoutedEventArgs e)
        {
            Dictionary<String, String> memberLogin = new Dictionary<string, string>();
            memberLogin.Add("email", "xuanhung2401@gmail.com");
            memberLogin.Add("password", "123");
            HttpClient httpClient = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(memberLogin), System.Text.Encoding.UTF8, "application/json");
            var a = await httpClient.PostAsync(API_LOGIN, content).Result.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
        }

        //Validate các trường trong form Login xem có đủ yêu câu ko.
        private void Login_Handle(object sender, TappedRoutedEventArgs e)
        {
            var username = Email.Text;
            var password = Password.Password.ToString();
            if (username == "")
            {
                Username_Message.Text = "Trường username không được để trống.";
                Username_Message.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                Username_Message.Text = "";
            }
            if (password == "")
            {
                Password_Message.Text = "Trường password sai hoặc không được để trống.";
                Password_Message.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                Password_Message.Text = "";
            }
            if (username != "" && password != "")
            {
                this.LoginFrame.Navigate(typeof(View.SplitView)); ;
            }
        }

        //Register Frame (Di chuyển sang trang Register nếu chưa có tài khoản.)
        private void btn_Sign_Up(object sender, TappedRoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            this.Hide();
            rootFrame.Navigate(typeof(RegisterForm));
        }


    }
}
