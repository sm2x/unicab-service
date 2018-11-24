using System;
using System.Collections.Generic;
using System.Text;

namespace UnicabApp.Models
{
    public class UpcomingRide
    {
        public string PickupLocation { get; set; }

        public string DropoffLocation { get; set; }

        public DateTime PickupDateTime { get; set; }

        public int NoOfSeats { get; set; }

        public bool LadiesOnly { get; set; }

        public string AdditionalNotes { get; set; }
        
    }
}
