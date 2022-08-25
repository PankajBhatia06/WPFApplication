using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public class Product : BaseModel, IDataErrorInfo
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


        private int _SelectedCategory;
        public int SelectedCategory
        {
            get
            {
                return _SelectedCategory;
            }
            set
            {
                _SelectedCategory = value;
                NotifyPropertyChanged();
            }
        }


        private int _SelectedBrand;
        public int SelectedBrand
        {
            get
            {
                return _SelectedBrand;
            }
            set
            {
                _SelectedBrand = value;
                NotifyPropertyChanged();
            }
        }

        private int _SelectedUom;
        public int SelectedUom
        {
            get
            {
                return _SelectedUom;
            }
            set
            {
                _SelectedUom = value;
                NotifyPropertyChanged();
            }
        }

        private bool _IsAvailable;
        public bool IsAvailable
        {
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


        private bool _OpeningStock;
        public bool OpeningStock
        {
            get
            {
                return _OpeningStock;
            }
            set
            {
                _OpeningStock = value;
                NotifyPropertyChanged();
            }
        }


        private string _OtherBrand;
        public string OtherBrand
        {
            get
            {
                return _OtherBrand;
            }
            set
            {
                _OtherBrand = value;
                NotifyPropertyChanged();
            }
        }
        public string this[string columnName] => throw new NotImplementedException();

        public string Error => throw new NotImplementedException();
    }
}
