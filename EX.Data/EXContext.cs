using Microsoft.EntityFrameworkCore;

namespace EX.Data
{
    public class EXContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = MyDB; 
                                        Integrated Security = true");
        }

    }
}