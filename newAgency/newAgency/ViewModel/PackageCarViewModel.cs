using newAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newAgency.ViewModel
{
    public class PackageCarViewModel
    {
        Sno7yEntities context = new Sno7yEntities();
        public string packageName { get; set; }
        public decimal packagePrice { get; set; }
        public List<car> carAvailable { get; set; } = new List<car>();
        public List<int> IDCars { get; set; } = new List<int>();
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool available { get; set; }
        public PackageCarViewModel()
        {
            carAvailable = context.cars.ToList();
        }
    }
}