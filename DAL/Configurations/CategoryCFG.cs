using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class CategoryCFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasMaxLength(50);
            builder.HasData(
                new Category {CategoryID = 1, CategoryName = "Meyveler" },
                new Category {CategoryID = 2, CategoryName = "Sebzeler" },
                new Category {CategoryID = 3, CategoryName = "Süt Ve Süt Ürünleri" },
                new Category {CategoryID = 4, CategoryName = "Et ve Et Ürünleri" },
                new Category {CategoryID = 5, CategoryName = "Tatlılar" },
                new Category {CategoryID = 6, CategoryName = "Tahıllar" },
                new Category {CategoryID = 7, CategoryName = "Çerezler" },
                new Category {CategoryID = 8, CategoryName = "İçecekler" },
                new Category {CategoryID = 9, CategoryName = "Unlu Mamuller" }
                );
        }
    }
}
