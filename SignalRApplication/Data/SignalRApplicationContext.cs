using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalRApplication.Models;

namespace SignalRApplication.Data
{
    public class SignalRApplicationContext : DbContext
    {
        public SignalRApplicationContext (DbContextOptions<SignalRApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SignalRApplication.Models.Person> Person { get; set; } = default!;
    }
}
