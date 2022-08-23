using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Product : INotifyPropertyChanged,IDataErrorInfo
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

        private Boolean _IsAvailable;
        public Boolean IsAvailable 
        { 
            get
            {
                return _IsAvailable;
            }
            set 
            {
                _IsAvailable = value; 
                NotifyPropertyChanged();
            }
        }

        private Double _OpeningStock;
        public Double OpeningStock
        {
            get
            {
                return (Double)(_OpeningStock);
            }
            set
            {
                _OpeningStock = value;
                NotifyPropertyChanged();
            }
        }


        public List<string> SelectedCategory { get; set; }
        public List<string> SelectedBrand { get; set; }
        public List<string> SelectedUOM { get; set; }

        public bool CheckBoxSample { get; set; }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(OpeningStock):
                        if (OpeningStock<0)
                        {
                            return "Enter a valid value";
                        }
                        break;
                }
                return "";
            }
        }

        public Product()
        {

            SelectedCategory = new List<string>
            {
                "TOYS",
                "FASHION AND BEAUTY",
                "HEALTH AND PERSONAL CARE",
                "MOBILES AND ELECTRONIC DEVICES",
                "BOOKS AND EDUCATION"
            };

            SelectedBrand = new List<string>
            {
                "LEVIS",
                "MADAME",
                "NYKAA",
                "ZARA",
                "VEN HUSSAIN",
                "H$M"
            };

            SelectedUOM = new List<string>
            {
                "PIECES",
                "KILOGRAMS",
                "LITRES"
            };
        }
         public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }     
}

