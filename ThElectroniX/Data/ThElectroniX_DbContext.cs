using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThElectroniX.Models;

namespace ThElectroniX.Data
{
    public class ThElectroniX_DbContext :DbContext
    {
        public ThElectroniX_DbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Category> Categories { get; set; }
    }
}
