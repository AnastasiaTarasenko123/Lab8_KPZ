using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViCat.UI.ViewModels
{
    public class DataViewModel: ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
        }
        private string _visibleControl = "Cats";
        private ObservableCollection<UsersViewModel> _Users;
        private ObservableCollection<AppearanceViewModel> _Appearances;
        private ObservableCollection<CatViewModel> _Cats;
        public ICommand SetControlVisibility { get; set; }

        public string VisibleControl
        {
            get
            {
                return _visibleControl;
            }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }
        public ObservableCollection<CatViewModel> Cats
        {
            get
            {
                return _Cats;
            }
            set
            {
                _Cats = value;
                OnPropertyChanged("Cats");
            }
        }
        public ObservableCollection<UsersViewModel> Users
        {
            get
            {
                return _Users;
            }
            set
            {
                _Users = value;
                OnPropertyChanged("Users");
            }
        }
        public ObservableCollection<AppearanceViewModel> Appearances
        {
            get
            {
                return _Appearances;
            }
            set
            {
                _Appearances = value;
                OnPropertyChanged("Appearances");
            }
        }
    }
}
