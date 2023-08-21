using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SM.Domain.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ContextBinding
{
    public class Productbinding : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Picture);
            builder.Property(x => x.PictureAlt);
            builder.Property(x => x.PictureTitle);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.Keywords);
            builder.Property(x => x.Name);
            builder.Property(x => x.Slug);
            builder.Property(x => x.CategoryId);
            builder.Property(x => x.Code);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.Description);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.CreationDate);
        }
    }
}
