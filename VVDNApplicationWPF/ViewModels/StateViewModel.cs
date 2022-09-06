using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class StateViewModel
    {
        private readonly StateService stateService;
        public State SelectedState { get; set; }

        public StateViewModel()
        {


            SelectedState = new State();
            stateService = new StateService();
        }

        public bool SaveState()
        {
            return stateService.InsertState(SelectedState);
        }
    }
}
