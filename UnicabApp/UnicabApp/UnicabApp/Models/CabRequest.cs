using System;
using System.Collections.Generic;
using System.Text;

namespace UnicabApp.Models
{
    public class CabRequest
    {
        public string PickupLocation { get; set; }

        public string DropoffLocation { get; set; }

        public DateTime PickupDate { get; set; }

        public TimeSpan PickupTime { get; set; }

        public int NoOfPassengers { get; set; }

        public bool LadiesOnly { get; set; }

        public string AdditionalNotes { get; set; }
    }
}
