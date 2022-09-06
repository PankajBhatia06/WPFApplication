using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Customer : BaseModel
    {
        private int _Id;
        public int Id { get { return _Id; }
            set { _Id = value; NotifyPropertyChanged("Id"); } }

        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; NotifyPropertyChanged("Name"); } }

        private string _Address1;
        public string Address1 { get { return _Address1; } set { _Address1 = value;NotifyPropertyChanged("Address"); } }

        private string _Address2;
        public string Address2 { get { return _Address2; } set { _Address2=value; NotifyPropertyChanged("Address"); } }

        private int _Country;
        public int Country { get { return _Country; } set { _Country = value; NotifyPropertyChanged("Country"); } }

        private string _State;
        public string State { get { return _State; } set { _State = value; NotifyPropertyChanged("State"); } }

        private string _City;
        public string City { get { return _City; } set { _City = value;NotifyPropertyChanged("City"); } }

        private string _MobileNumber;
        public string MobileNumber { get { return _MobileNumber; } set { _MobileNumber = value; NotifyPropertyChanged("MobileNumber"); } }

        private string _EmailId;
        public string EmailId { get { return _EmailId; } set { _EmailId = value; NotifyPropertyChanged("EmailId"); } }


    }
}
