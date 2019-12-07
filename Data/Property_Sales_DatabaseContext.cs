using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Property_Sales_Final_Project.Models;

namespace Property_Sales_Final_Project.Models
{
    public class Property_Sales_DatabaseContext : DbContext
    {
        public Property_Sales_DatabaseContext (DbContextOptions<Property_Sales_DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Property_Sales_Final_Project.Models.Buyer> Buyer { get; set; }

        public DbSet<Property_Sales_Final_Project.Models.Property> Property { get; set; }

        public DbSet<Property_Sales_Final_Project.Models.SalesTransaction> SalesTransaction { get; set; }
    }
}
