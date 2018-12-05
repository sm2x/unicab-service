using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using UCAppServer.Models;

namespace UCAppServer.Contexts
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
