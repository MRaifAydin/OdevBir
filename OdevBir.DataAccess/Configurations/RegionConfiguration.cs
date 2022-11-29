using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdevBir.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.DataAccess.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(e => e.RegionId).IsClustered(false);

            builder.ToTable("Region");

            builder.Property(e => e.RegionId)
                .ValueGeneratedNever()
                .HasColumnName("RegionID");
            builder.Property(e => e.RegionDescription)
                .HasMaxLength(50)
                .IsFixedLength();
        }
    }
}
