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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex(e => e.CategoryName, "CategoryName");

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");
            builder.Property(e => e.CategoryName).HasMaxLength(15);
            builder.Property(e => e.Description).HasColumnType("ntext");
            builder.Property(e => e.Picture).HasColumnType("image");
        }
    }
}
