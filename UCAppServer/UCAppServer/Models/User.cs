﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UCAppServer.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MatricsNo { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNo { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte[] MatricsCardPhoto { get; set; }

        public DateTime AddedDateTime { get; set; }

        public bool IsVerified { get; set; }

        public DateTime VerifiedDateTime { get; set; }

        public bool IsBlacklisted { get; set; }

        public DateTime BlacklistedDateTime { get; set; }

        public string BlacklistedReason { get; set; }

    }
}
