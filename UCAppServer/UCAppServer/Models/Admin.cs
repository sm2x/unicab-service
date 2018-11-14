using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UCAppServer.Models
{
    public class Admin : User
    {
        public string AdminType { get; set; }
    }
}
