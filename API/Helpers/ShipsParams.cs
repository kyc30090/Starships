using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class ShipsParams : PageParams
    {
        public string Orderby { get; set; }
        public string SearchTerm { get; set; }
        public string ShipClasses { get; set; }
    }
}