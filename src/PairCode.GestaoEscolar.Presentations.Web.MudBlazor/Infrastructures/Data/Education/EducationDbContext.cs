using Microsoft.EntityFrameworkCore;
using PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Core.Domain.Education.Entities;
using PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Infrastructures.Data.Education.EntityMappings;

namespace PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Infrastructures.Data.Education
{
    public class EducationDbContext : DbContext
    {
        public DbSet<SchoolGroup> SchoolGroups { get; set; }
        public DbSet<School> Schools { get; set; }
        public EducationDbContext() : base()
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
        }
        public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("EducationDb");

            modelBuilder.ApplyConfiguration(new SchoolGroupMap());
            modelBuilder.ApplyConfiguration(new SchoolMap());
        }
    }
}
