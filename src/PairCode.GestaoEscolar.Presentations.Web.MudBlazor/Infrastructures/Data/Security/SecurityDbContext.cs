using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PairCode.GestaoEscolar.Core.Domain.Security.Entities;

namespace PairCode.GestaoEscolar.Infrastructures.Data.Security
{
    public class SecurityDbContext : IdentityDbContext<User>
    {
        public SecurityDbContext() : base()
        {
            if (Database.IsRelational())
                Database.Migrate();
        }
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options)
        {
            if (Database.IsRelational())
                Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w => w.Ignore(SqlServerEventId.SavepointsDisabledBecauseOfMARS));

            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("SecurityDb");

            base.OnModelCreating(builder);
        }
    }
}
