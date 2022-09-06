using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class State : BaseModel, IDataErrorInfo
    {
        private int _StateId;
        public int StateId
        {
            get
            {
                return _StateId;
            }

            set
            {
                _StateId = value;
                NotifyPropertyChanged("StateId");
            }
        }

        private string _StateName;

        public string StateName
        {
            get
            {
                return _StateName;
            }
            set
            {
                _StateName = value;
                NotifyPropertyChanged("StateName");
            }
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "StateName":
                        if (string.IsNullOrWhiteSpace(StateName))
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