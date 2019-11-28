using System.Collections.ObjectModel;

namespace ViCat.UI.ViewModels
{
    public class CatViewModel: ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private Genders _gender;
        public Genders Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }
        private double _age;  
        public double Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        private Appearance _appearance;
        public Appearance Appearance
        {
            get
            {
                return _appearance;
            }
            set
            {
                _appearance = value;
                OnPropertyChanged("Appearance");
            }
        }
        private int _indexEating;
        public int IndexEating
        {
            get
            {
                return _indexEating;
            }
            set
            {
                _indexEating = value;
                OnPropertyChanged("IndexEating");
            }
        }
        private int _indexCleanness;
        public int IndexCleanness
        {
            get
            {
                return _indexCleanness;
            }
            set
            {
                _indexCleanness = value;
                OnPropertyChanged("IndexCleanness");
            }
        }
        private int _indexHappiness;
        public int IndexHappiness
        {
            get
            {
                return _indexHappiness;
            }
            set
            {
                _indexHappiness = value;
                OnPropertyChanged("IndexHappiness");
            }
        }
        private int _indexTiredness;
        public int IndexTiredness
        {
            get
            {
                return _indexTiredness;
            }
            set
            {
                _indexTiredness = value;
                OnPropertyChanged("IndexTiredness");
            }
        }
        private int SetIndex(int index, int size)
        {
            if (index + size >= 100)
            {
                return 100;
            }
            else if(index + size <= 0)
            {
                return 0;
            }
            return index + size;
        }
        public void Feed(int size)
        {
            IndexEating = SetIndex(IndexEating, size);
        }
        public void Washing(int size)
        {
            IndexCleanness = SetIndex(IndexCleanness, size);
            IndexTiredness = SetIndex(IndexTiredness, size / 2);
            IndexEating = SetIndex(IndexEating, - size / 2);
            IndexHappiness = SetIndex(IndexHappiness, -size*2);
        }
        public void Sleep(int size)
        {
            IndexTiredness = SetIndex(IndexTiredness, -size);
            IndexEating = SetIndex(IndexEating, - size / 2);
        }
        public void Play(int size)
        {
            IndexHappiness = SetIndex(IndexHappiness, size);
            IndexTiredness = SetIndex(IndexTiredness, size);
            IndexEating = SetIndex(IndexEating, -size*2);
            IndexCleanness = SetIndex(IndexCleanness, -size*2);
        }

        //private ObservableCollection<CatViewModel> _Cats;
        //public ObservableCollection<CatViewModel> Cats
        //{
        //        get
        //        {
        //            return _Cats;
        //        }
        //        set
        //        {
        //            _Cats = value;
        //            OnPropertyChanged("Cats");
        //        }
        //    }

    }
}
