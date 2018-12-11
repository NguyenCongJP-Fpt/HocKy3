using KaniMusic_UWP.Data;
using KaniMusic_UWP.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
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

namespace KaniMusic_UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListView : Page
    {
        private ObservableCollection<Song> listSong;


        internal ObservableCollection<Song> ListSong { get => listSong; set => listSong = value; }

        public ListView()
        {
            this.ListSong = new ObservableCollection<Song>();
            this.ListSong.Add(new Song()
            {
                name = "Bai Hat 1",
                thumbnail = "https://i2.wp.com/www.codeproject.com/KB/GDI-plus/ImageProcessing2/img.jpg"
            });
            this.ListSong.Add(new Song()
            {
                name = "Bai Hat 2",
                thumbnail = "http://legacy.semantic-ui.com/images/demo/photo.jpg"
            });

            this.InitializeComponent();
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            //this.ListSong.Add(new Song()
            //{
            //    name = SongName.Text,
            //    thumbnail = SongThumbnail.Text
            //});
            Contacts c = new Contacts()
            {
                name = SongName.Text,
                phone = SongThumbnail.Text,
                email = SongName.Text + "@gmail.com"
            };
            ContactModel.Add(c);
        }

        private void goToHome(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
