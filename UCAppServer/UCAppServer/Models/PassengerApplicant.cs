using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class PassengerApplicant
    {
        public int PassengerApplicantId { get; set; }

        public string EmailAddress { get; set; }

        public string MatricsNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte[] MatricsCardPhoto { get; set; }

        public DateTime ApplicationDateTime { get; set; }
        
    }
}
