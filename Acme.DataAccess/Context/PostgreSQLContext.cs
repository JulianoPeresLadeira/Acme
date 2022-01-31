using Acme.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Acme.DataAccess.Context
{
    public class PostgreSQLContext : DbContext
    {
        internal DbSet<ProductEntity> Products { get; set; }

        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options)
        {
        }
    }
}
