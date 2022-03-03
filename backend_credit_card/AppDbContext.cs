using backend_credit_card.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_credit_card
{
    public class AppDbContext: DbContext
    {
        public DbSet<CreditCard> CreditCard{ get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
