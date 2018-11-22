using System;
using System.Collections.Generic;
using System.Text;

namespace UnicabApp.Models
{
    public class Driver
    {
        public string EmailAddress { get; set; }

        public string MatricsNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        //public byte[] MatricsCardPhoto { get; set; }

        //public byte[] DrivingLicensePhoto { get; set; }

        // Car details

        public string CarPlateNo { get; set; }

        public DateTime RoadTaxDueDate { get; set; }

        //public byte[] CarInsuranceGrantPhoto { get; set; }
    }
}
