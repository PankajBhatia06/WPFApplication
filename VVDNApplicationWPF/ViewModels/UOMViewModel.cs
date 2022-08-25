using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.ViewModels
{
    public class UOMViewModel
    {
       
        public UnitOfMeasurement SelectedUnitofMeasurement { get; set; }

        public UOMViewModel()
        {

            SelectedUnitofMeasurement = new UnitOfMeasurement();
        }



    }
}
