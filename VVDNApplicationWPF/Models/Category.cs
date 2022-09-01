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

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                NotifyPropertyChanged("Name");
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
                        break;
                    case "Id":
                        if (Id.Equals(0))
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
