using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BitAnalytics.Models;

namespace BitAnalytics.Data
{
    public class BitAnalyticsContext : DbContext
    {
        public BitAnalyticsContext (DbContextOptions<BitAnalyticsContext> options)
            : base(options)
        {
        }

        public DbSet<BitAnalytics.Models.Vehicle> Vehicle { get; set; }
    }
}
