using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Products : INotifyPropertyChanged, IDataErrorInfo
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
        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Name":
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            return "Enter a value";
                        }
                        else if (!string.IsNullOrWhiteSpace(Name) && Name.Equals("Test"))
                        {
                            return "This name is not allowed";
                        }
                        break;
                    case "Id":
                        if (Id <= 0)
                            return "Id greater than 0";
                        break;
                    default:
                        break;
                }
                return "";
            }


        }

        public List<string> SelectedProduct { get; set; }
        public List<string> SelectedBrands { get; set; }
        public List<string> SelectedUOMs { get; set; }



        public Products()
         {
             SelectedProduct = new List<string>
            {
                "Surbhi",
                "Shagun",
                "Deepanshu",
                "Vansh",
                "Amit",
                "Neeraj",
                "Sushant",
                "Hadiya",
                "Sachin",
                "Sumit",
                "Ankur"};

            SelectedBrands = new List<string>
            {
                "Microsoft",
                "DELL",
                "NIKE",
                "ZARA",
                "GUCCI",
                "Pepe",

             };


            SelectedUOMs = new List<string>
            {
                "Pair",
                "Piece",
                "KG",
                "Litre",
                "Set",


            };



        }



       
       
     
       
    
    }  
}










