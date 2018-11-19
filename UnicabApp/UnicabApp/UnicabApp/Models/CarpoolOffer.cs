using System;
using System.Collections.Generic;
using System.Text;

namespace UnicabApp.Models
{
    public class CarpoolOffer
    {
        public string DrivingFrom { get; set; }

        public string DrivingTo { get; set; }

        public DateTime DepartingDate { get; set; }

        public TimeSpan DepartingTime { get; set; }

        public int NoOfSeats { get; set; }

        public bool LadiesOnly { get; set; }

        public string AdditionalNotes { get; set; }
    }
}
