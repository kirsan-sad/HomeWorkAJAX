using AJAX.DAL.ModelsDAL;
using Microsoft.EntityFrameworkCore;

namespace AJAX.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<ShopDAL> Shops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Shopdb;Integrated Security=True");
        }
    }
}
