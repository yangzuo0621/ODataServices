using Microsoft.EntityFrameworkCore;

namespace CsvToolDb.Models
{
    public class CsvToolContext : DbContext
    {
        public CsvToolContext(DbContextOptions<CsvToolContext> options)
            : base(options)
        { }

        public DbSet<Request> Requests { get; set; }
    }
}