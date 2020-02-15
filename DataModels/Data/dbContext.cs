
using Microsoft.EntityFrameworkCore;

namespace DataModels
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
