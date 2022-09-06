using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Country : BaseModel, IDataErrorInfo
    {
        private int _CountryId;
        public int CountryId
        {
            get
            {
                return _CountryId;
            }

            set
            {
                _CountryId = value;
                NotifyPropertyChanged("CountryId");
            }
        }

        private string _CountryName;

        public string CountryName
        {
            get
            {
                return _CountryName;
            }
            set
            {
                _CountryName = value;
                NotifyPropertyChanged("CountryName");
            }
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "CountryName":
                        if (string.IsNullOrWhiteSpace(CountryName))
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