using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Brandswith : INotifyPropertyChanged,IDataErrorInfo

    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void INotifyPropertyChanged( string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Brandswith()
        {

            ID = 123456;
            Name = "test a String";

        } 
        private  int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
                INotifyPropertyChanged();
            }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value;
                INotifyPropertyChanged();
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
                        else if (!string.IsNullOrWhiteSpace(Name) && Name.Equals("Brand"))
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
