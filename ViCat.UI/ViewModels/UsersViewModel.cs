using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViCat.UI.ViewModels
{
    public class UsersViewModel:ViewModelBase
    {
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        private List<Cat> _cats;
        public List<Cat> Cats
        {
            get
            {
                return _cats;
            }
            set
            {
                _cats = value;
                OnPropertyChanged("Cats");
            }
        }
        public void AddCat(Cat cat)
        {
            if (cat != null)
            {
                _cats.Add(cat);
            }
        }
    }
}
