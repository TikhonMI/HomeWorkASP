using Microsoft.EntityFrameworkCore;
using MvcCreditApp.Models; //Lab5.1(3)2

namespace MvcCreditApp.Data //Lab5.1(3)2
{
    public class CreditContext: DbContext //Lab5.1(3)1 унаследованный от класса DbContext
    {
        //Lab5.1(3)2
        public CreditContext(DbContextOptions<CreditContext> options): base(options)
        { }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}
