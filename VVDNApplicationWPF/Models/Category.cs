using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Category : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Category()
        {
            Id = 12345;
            Name = "Test Name";
        }


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

        public string Error => throw new NotImplementedException();

        public string this[string columnName] //fixed syntax
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrWhiteSpace(Name))
                        {
                            return "Enter a value";
                        }
                        else if (!string.IsNullOrWhiteSpace(Name) && Name.Equals("Test"))
                        {
                            return "This name is not allowed";
                        }
                        break;
                    case nameof(Id):
                        if (!Id.Equals(1))
                        {
                            return "Enter a value";
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
