using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string CarType { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public int CarMakeYear { get; set; }

        public string CarPlateNo { get; set; }

        public string CarRoadTaxDueDate { get; set; }

        public int CarSeatsAvailable { get; set; }
    }
}
