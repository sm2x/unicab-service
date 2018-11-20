using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicabAdminCore.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        public string EmailAddress { get; set; }

        public string MatricsNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public byte[] MatricsCardPhoto { get; set; }

        public byte[] DrivingLicensePhoto { get; set; }

        // Car details

        public string CarPlateNo { get; set; }

        public DateTime RoadTaxDueDate { get; set; }

        public byte[] CarInsuranceGrantPhoto { get; set; }

        // Admin approval

        public DateTime ApprovedDateTime { get; set; }

        public string ApprovedBy { get; set; }

        // Blacklist

        public bool IsBlacklisted { get; set; }

        public string BlacklistedBy { get; set; }

        public string BlacklistedReason { get; set; }

        public string BlacklistedDateTime { get; set; }

    }
}