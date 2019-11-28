using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViCat.UI.ViewModels;

namespace ViCat.UI.Views
{
    /// <summary>
    /// Логика взаимодействия для CatUserControl.xaml
    /// </summary>
    public partial class CatUserControl : UserControl
    {
        public CatUserControl()
        {
            InitializeComponent();
        }
        private void ButtonPlay(object sender, RoutedEventArgs e)
        {
            var cat = (CatViewModel)catGrid.SelectedItem;
            cat.Play(10);
        }
        private void ButtonFeed(object sender, RoutedEventArgs e)
        {
            var cat = (CatViewModel)catGrid.SelectedItem;
            cat.Feed(10);
        }
        private void ButtonWash(object sender, RoutedEventArgs e)
        {
            var cat = (CatViewModel)catGrid.SelectedItem;
            cat.Washing(10);
        }
        private void ButtonSleep(object sender, RoutedEventArgs e)
        {
            var cat = (CatViewModel)catGrid.SelectedItem;
            cat.Sleep(10);
        }
    }
}
