using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using T1708E_Demo1.Entity;
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

namespace T1708E_Demo1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginForm : Page
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        //gán Event sau khi click vào phím Login sẽ chuyển sang Main Page.
        private void btn_Login(object sender, RoutedEventArgs e)
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
            if (username != "" &&  password != "")
            {
                this.LoginFrame.Navigate(typeof(View.SplitView)); ;
            }
            //this.LoginFrame.Navigate(typeof(View.SplitView));
        }

        private void btn_RegisterForm(object sender, RoutedEventArgs e)
        {
            this.LoginFrame.Navigate(typeof(MainPage));
        }
    }
}
