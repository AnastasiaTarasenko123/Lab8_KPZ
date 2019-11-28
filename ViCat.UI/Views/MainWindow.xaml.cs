using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using ViCat.UI.ViewModels;

namespace ViCat.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            App._model.Save();
        }

        private void Button_ShowRules(object sender, RoutedEventArgs e)
        {
            var rules = new Rules();
            rules.Show();
        }
        private void soundplayer_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri("cat.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }
    }
}