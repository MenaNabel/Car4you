using layOut20192.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace layOut20192.ViewModels
{
    public class reservePackageViewModel
    {
        public string ClientSSNA { get; set; }
        public List<package> packagesAvalible { get; set; } = new List<package>();
        public List<type_client> typeClient { get; set; } = new List<type_client>();

    }
}