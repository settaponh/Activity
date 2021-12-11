using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivityAPI.Models;

namespace ActivityAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        {

        }
        public DbSet<Activity> Activities { get; set; }
    }
}
