using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class UOM : INotifyPropertyChanged,IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public UOM()
        {
             ID = 12334;
            Name = "test a Name";
        }
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
        public string Name { get
            {
                return _Name;
            }
            set
            {
                _Name = value;
               NotifyPropertyChanged();
            } 
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
                    default:
                        break;
                }
                return "";
            }
        }
    }
}
