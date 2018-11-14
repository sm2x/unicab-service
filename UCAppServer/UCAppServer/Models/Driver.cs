using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class Driver : User
    {
        public int CarId { get; set; }

        public string LicenseDueDate { get; set; }

        public int TotalRides { get; set; }

        public int TotalCarpools { get; set; }

        //public double AverageRatings { get; set; }
    }
}
