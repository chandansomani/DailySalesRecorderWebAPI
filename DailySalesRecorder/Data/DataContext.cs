

using DailySalesRecorder.Models;

namespace DailySalesRecorder.Data
{
    public class DataContext : DbContext
    {
        //DbContext _context;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

            
        }

        public DbSet<Farmer> Farmers => Set<Farmer>();
        public DbSet<Invoice> Invoices => Set<Invoice>();

    }
}
