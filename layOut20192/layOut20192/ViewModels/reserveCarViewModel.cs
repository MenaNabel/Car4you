using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace layOut20192.ViewModels
{
    public class reserveCarViewModel
    {
        public string ClientSSNA { get; set; }
        public car carAvalible { get; set; } 
        public List<type_client> typeClient { get; set; } = new List<type_client>();
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}