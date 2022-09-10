using Microsoft.EntityFrameworkCore;

namespace ClassroomDatabaseEFCoreLab
{
    public class ClassContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TROYPC;Database=CodeFirstExample;Integrated Security=SSPI;");
        }
    }
}
