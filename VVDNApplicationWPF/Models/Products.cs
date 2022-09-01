using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Products : INotifyPropertyChanged
    {






        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
                NotifyPropertyChanged();
            }
        }

        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
        


        



        private int _selectedCategory;
        public int SelectedCategory
        {

            get
            {
               return _selectedCategory;

            }

            set
            {
                _selectedCategory = value;
                NotifyPropertyChanged();
            }
        }


        private int _selectedBrand;
        public int SelectedBrand
        {

            get
            {
                return _selectedBrand;

            }

            set
            {
                _selectedBrand = value;
                NotifyPropertyChanged();
            }
        }



        private int  _selectedUOM;
        public int SelectedUOM
        {

            get
            {
                return _selectedUOM;

            }

            set
            {
                _selectedUOM = value;
                NotifyPropertyChanged();
            }
        }





    }  
}










