using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Core.Domain.Education.Entities;

namespace PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Infrastructures.Data.Education.EntityMappings
{
    public class SchoolMap : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .Property<long>(p => p.Id)
                .HasColumnType("BIGINT")
                .HasColumnName("Id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn()
                .IsRequired(true);

            builder
                .Property<string>(e => e.TradeName)
                .HasColumnType("NVARCHAR(128)")
                .HasColumnName("TradeName")
                .IsRequired(true);

            builder
                .Property<string>(e => e.CompanyName)
                .HasColumnType("NVARCHAR(256)")
                .HasColumnName("CompanyName")
                .IsRequired(true);

            builder
                .Property<string>(e => e.TaxIdentificationNumber)
                .HasColumnType("NVARCHAR(64)")
                .HasColumnName("TaxIdentificationNumber")
                .IsRequired(true);

            builder
                .Property<DateTime>(e => e.FoundedAt)
                .HasColumnType("DATETIME")
                .HasColumnName("FoundedAt")
                .IsRequired(true);

            builder
                .HasKey(e => e.Id);

            builder
                .ToTable("Schools");

            builder
                .HasOne(e => e.SchoolGroup)
                .WithMany(e => e.Schools)
                .HasForeignKey(e => e.SchoolGroupId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
