﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicabApp.Driver
{

    public class DriverHomePageMenuItem
    {
        public DriverHomePageMenuItem()
        {
            //TargetType = typeof(DriverHomePageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public String IconSource { get; set; }
    }
}