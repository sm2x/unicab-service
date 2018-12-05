using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class Driver : User
    {
        public string DriverPassword { get; set; }

        public byte[] DrivingLicensePhoto { get; set; }

        public string CarPlateNo { get; set; }

        public string CarMake { get; set; }

        public string CarModel { get; set; }

        public string CarMakeYear { get; set; }

        public string CarColour { get; set; }

        public DateTime CarRoadTaxDueDate { get; set; }

        public byte[] CarInsuranceGrantPhoto { get; set; }
    }
}
