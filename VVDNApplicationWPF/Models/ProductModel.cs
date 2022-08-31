using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class ProductModel : INotifyPropertyChanged, IDataErrorInfo
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
                NotifyPropertyChanged("Id");
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
                NotifyPropertyChanged("Name"); }
        }

        
        private bool _IsAvailable;

        public bool IsAvailable
        {
            get
            {
                return _IsAvailable; 
            }
            set
            { 
                _IsAvailable = value;
                NotifyPropertyChanged("IsAvailable");
            }
        }

        private double _OpeningStock;

        public double OpeningStock
        {
            get 
            {
                return _OpeningStock; 
            }
            set
            {

                _OpeningStock = value;
                NotifyPropertyChanged("OpeningStock");
            }
        }

        private int _SelectedCategory;

        public int SelectedCategory
        {
            get { return _SelectedCategory; }
            set { _SelectedCategory = value;
                NotifyPropertyChanged("SelectedCategory");
            }
        }

        private int _SelectedBrand;

        public int SelectedBrand
        {
            get { return _SelectedBrand; }
            set { _SelectedBrand = value;
                NotifyPropertyChanged("SelectedBrand");
            }
        }

        private int _SelectedUom;

        public int SelectedUom
        {
            get { return _SelectedUom; }
            set { _SelectedUom = value;
                NotifyPropertyChanged("SelectedUom");
            }
        }



        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(OpeningStock):
                        if (OpeningStock>0)
                        {
                            return "Enter a value";
                        }
                        break;
                }
                return "";
            }
        }
        public string Error => throw new NotImplementedException();


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
