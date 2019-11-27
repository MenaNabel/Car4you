using newAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAgency.ViewModel
{
    public class reserveCarViewModel
    {
        public string ClientSSNA { get; set; }
        public List<car> carsAvalible { get; set; } = new List<car>();
        public List<type_client> typeClient { get; set; } = new List<type_client>();
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}