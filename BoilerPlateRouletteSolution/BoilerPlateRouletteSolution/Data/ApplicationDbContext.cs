using BoilerPlateRouletteSolution.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateRouletteSolution.Data
{
    public class ApplicationDbContext : DbContext
    {
        // DbContext class did not exist for inheritance before we added the nuget package
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // These are configurations
        {

        }
        // We want to create the NumbetStats table to our database. To do so...
        public DbSet<NumberStats> NumberStats { get; set; }
    }
}
