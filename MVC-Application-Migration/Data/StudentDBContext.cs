using Microsoft.EntityFrameworkCore;
using MVC_Application_Migration.Models;

namespace MVC_Application_Migration.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {

        }

        public DbSet<Studentregister> REGISTRATION { get; set; }
    }
}
