using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Product : INotifyPropertyChanged, IDataErrorInfo
    { 
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                NotifyPropertyChanged();
            }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                NotifyPropertyChanged();
            }
        }
        private bool _IsAvailable;
        public bool IsAvailablen {
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
        private double _OpeningStock;
        public double OpeningStock 
        {
            get
            {
                return (double)_OpeningStock;
            } set
            {
                _OpeningStock = value;
                NotifyPropertyChanged();
            }
        }
        public List<String> SelectedCategory { get; set; }
        public List<string> SelectedBrand { get; set; }
        public List<string> SelectedUOMs { get; set; }

        public bool CheckboxSample { get; set; }
        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Openingstock":
                        if (OpeningStock < 0)
                        {
                            return " Enter a valid value";
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
                "toys",
                "Cloths",
                "Shoes",
                "Grocery",
                "jewellery"
            };

            SelectedBrand = new List<string>
            {
                "H&M",
                "zara",
                "Zudio",
                "Aurelia",
                "Libas"
            };
            SelectedUOMs = new List<string>
            {
                "Quantities",
                "Piece",
                "One-Pair",
                " kg",
                "one-set"


            };

        }
    
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

    }

 }

