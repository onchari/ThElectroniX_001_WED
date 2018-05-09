using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ThElectroniX.Data;
using ThElectroniX.Models;

namespace TEST_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var options = new DbContextOptionsBuilder();
            var connstr = new SqlConnectionStringBuilder("Server=(localdb)\\MSSQLLocalDB;Database=ThElectroniX_001;Trusted_Connection=True;MultipleActiveResultSets=true");
            options.UseSqlServer(connstr.ConnectionString);
            using (var context = new ThElectroniX_DbContext(options.Options))
            {
                List<Category> list = context.Categories.ToList();

                foreach (Category cat in list)
                {
                    Console.WriteLine(cat.CategoryName);
                }
            };

            Console.ReadKey();
        }
    }
}
