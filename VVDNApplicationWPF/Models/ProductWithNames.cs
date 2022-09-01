using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVDNApplicationWPF.Models
{
    public partial class Product
    {
        private string _SelectedCategoryName;

        public string SelectedCategoryName
        {
            get { return _SelectedCategoryName; }
            set { _SelectedCategoryName = value; }
        }

        private string _SelectedBrandName;

        public string SelectedBrandName
        {
            get { return _SelectedBrandName; }
            set { _SelectedBrandName = value; }
        }


        private string _SelectedUomName;

        public string SelectedUomName
        {
            get { return _SelectedUomName; }
            set { _SelectedUomName = value; }
        }

    }
}
