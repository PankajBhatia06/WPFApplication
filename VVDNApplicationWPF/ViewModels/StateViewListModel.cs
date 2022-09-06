using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Models;
using VVDNApplicationWPF.Services;

namespace VVDNApplicationWPF.ViewModels
{
    public class StateViewListModel
    {
        private readonly StateService stateService;
        public List<State> StateList { get; set; }
        public StateViewListModel()
        {
            stateService = new StateService();
            LoadState();
        }

        public void LoadState()
        {
            try
            {
                StateList = stateService.GetAllState();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
