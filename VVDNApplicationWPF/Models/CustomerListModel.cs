using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class CustomerListModel : BaseModel
    {
        private int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; NotifyPropertyChanged("CustomerId"); }
        }
        private String _AddressLine1;
        public String AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; NotifyPropertyChanged("AddressLine1"); }
        }

        private String _AddressLine2;
        public String AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; NotifyPropertyChanged("AddressLine2"); }
        }
        private String _City;
        public String City
        {
            get { return _City; }
            set { _City = value; NotifyPropertyChanged("City"); }
        }

        private string _SelectedCustomerName;
        public string SelectedCustomerName
        {
            get { return _SelectedCustomerName; }
            set { _SelectedCustomerName = value; NotifyPropertyChanged("SelectedCustomerName"); }
        }

        private string _SelectedCountryName;
        public string SelectedCountryName
        {
            get { return _SelectedCountryName; }
            set { _SelectedCountryName = value; NotifyPropertyChanged("SelectedCountryName"); }
        }

        private string _SelectedStateName;
        public string SelectedStateName
        {
            get { return _SelectedStateName; }
            set { _SelectedStateName = value; NotifyPropertyChanged("SelectedStateName"); }
        }

        private string _SelectedMobileNumber;
        public string SelectedMobileNumber
        {
            get { return _SelectedMobileNumber; }
            set { _SelectedMobileNumber = value; NotifyPropertyChanged("SelectedMobileNumber"); }
        }

        private string _SelectedEmailId;
        public string SelectedEmailId
        {
            get { return _SelectedEmailId; }
            set { _SelectedEmailId = value; NotifyPropertyChanged("SelectedEmailId"); }
        }

    }
}
