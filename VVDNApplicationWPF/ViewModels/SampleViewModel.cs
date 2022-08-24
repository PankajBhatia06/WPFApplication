using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
    public class SampleViewModel : INotifyPropertyChanged
    {

        private bool _ListViewVisibility;

        public bool ListViewVisibility
        {

            get
            {
                return _ListViewVisibility;
            }
            set
            {
                _ListViewVisibility = value;
                NotifyPropertyChanged("ListViewVisibility");
            }
        }
        public List<string> ListOfString { get; set; }

        public List<DataGridModel> DataGridModels { get; set; }

        public bool CheckBoxSample { get; set; }

        public SampleViewModel()
        {
            ListViewVisibility = true;
            CheckBoxSample = true;
            ListOfString = new List<string>
            {
                "Surbhi",
                "Shagun",
                "Deepanshu",
                "Vansh",
                "Amit",
                "Neeraj",
                "Sushant",
                "Hadiya",
                "Sachin",
                "Sumit",
                "Ankur"
            };

            DataGridModels = new List<DataGridModel>();
            DataGridModels.Add(new DataGridModel
            {
                ID = 1,
                Name = "Sushank",
                IsAvailable = true
            });

            DataGridModels.Add(new DataGridModel
            {
                ID = 2,
                Name = "Unknown",
                IsAvailable = false
            });

            DataGridModels.Add(new DataGridModel
            {
                ID = 3,
                Name = "Shagun",
                IsAvailable = true
            });
           

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
