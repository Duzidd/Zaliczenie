using Zaliczenie.Models.domain;
using Microsoft.EntityFrameworkCore;

namespace Zaliczenie.data
{
    public class KolDbcontext : DbContext
    {
        public KolDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<userr> userr { get; set; }
    }
}
