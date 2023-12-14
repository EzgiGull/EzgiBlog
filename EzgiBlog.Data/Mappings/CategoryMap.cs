using EzgiBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzgiBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
      

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {

                Id = Guid.Parse("73CDF461-2E7B-42D8-9FC3-AE5525A5116B"),
                Name = "ASP NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category {
                Id = Guid.Parse("67966216-8006-46E1-ABA2-BEFBFCC8BE13"),
                Name = "ASP NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
            
           
        }
    }
}
