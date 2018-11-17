using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using UCAppServer.Models;

namespace UCAppServer.Contexts
{
    public class ApplicantsContext : DbContext
    {
        public ApplicantsContext(DbContextOptions<ApplicantsContext> options) : base(options)
        {

        }

        public DbSet<PassengerApplicant> PassengerApplicants { get; set; }
        public DbSet<DriverApplicant> DriverApplicants { get; set; }
    }
}
