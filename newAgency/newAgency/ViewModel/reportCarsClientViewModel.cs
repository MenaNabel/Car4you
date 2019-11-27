using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAgency.ViewModel
{
    public class reportCarsClientViewModel
    {
        public string carNumber { get; set; }
        public int carID { get; set; }
        public string typeCar { get; set; }
        public string clientName { get; set; }
        public string clientSSNA { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string typeReservation { get; set; }
        public Nullable<bool> pac { get; set; }
        public Nullable<int> packageID { get; set; }
        public Nullable<decimal> priceReservation { get; set; }

    }
}