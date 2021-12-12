using Manager.Domain.Entities;
using Manager.Infra.Mapping;

using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext()
        { }

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsnuilder)
        {
            optionsnuilder.UseSqlServer(@"Data Source=DESKTOP-RVHNPJ7\MSSQLSERVER1; Initial Catalog=UserManagerAPI; User Id=; Password=;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}