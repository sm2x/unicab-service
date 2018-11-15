using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class Passenger : User
    {

        public int TotalRides { get; set; }

        public int TotalCarpools { get; set; }

        //public double AverageRatings { get; set; }
    }
}
