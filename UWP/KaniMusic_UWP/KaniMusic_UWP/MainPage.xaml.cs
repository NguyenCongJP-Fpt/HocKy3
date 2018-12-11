using KaniMusic_UWP.Entity;
using KaniMusic_UWP.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KaniMusic_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        //private void btn_Menu(object sender, RoutedEventArgs e)
        //{
        //    this.MySplitView.IsPaneOpen = !this.MySplitView.IsPaneOpen;
        //}

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
                Frame.Navigate(typeof(MainPage));

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
                Frame.Navigate(typeof(Views.ListView));

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

        private async void btnLogin(object sender, RoutedEventArgs e)
        {
            Login loginShow = new Login();
            await loginShow.ShowAsync();

        }

        //private async void btnUploadSong(object sender, RoutedEventArgs e)
        //{
        //    CreateSong uploadSong = new CreateSong();
        //    await uploadSong.ShowAsync();
        //}

        private async void btnRegister(object sender, RoutedEventArgs e)
        {
            Register registerShow = new Register();
            await registerShow.ShowAsync();
        }
    }
}
