﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class DriverApplicant
    {
        public int DriverApplicantId { get; set; }

        public string EmailAddress { get; set; }

        public string MatricsNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte[] MatricsCardPhoto { get; set; }

        public byte[] DrivingLicensePhoto { get; set; }

        public string CarPlateNo { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public string CarMakeYear { get; set; }

        public string CarColour { get; set; }

        public DateTime CarRoadTaxDueDate { get; set; }

        public byte[] CarInsuranceGrantPhoto { get; set; }

        public DateTime ApplicationDateTime { get; set; }

    }
}
