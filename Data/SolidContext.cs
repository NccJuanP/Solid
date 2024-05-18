using Microsoft.EntityFrameworkCore;
using solid.Models;

namespace solid.Data
{
    public class SolidContext : DbContext
    {
        public SolidContext(DbContextOptions<SolidContext> options) : base (options){

        } 

        public DbSet<Company> Companies { get; set; }
    }
}