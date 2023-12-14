using EzgiBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EzgiBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Deneme Makalesi 1",
                Content = "Lorem ipsum dolor sit amet consectetur adipiscing elit mattis cras, sed etiam sodales mus pretium dapibus magna varius ut, tellus euismod eget dis porta magnis lacinia ac. Nascetur iaculis interdum facilisi donec nunc hendrerit sem integer vestibulum, ad proin ultrices magna cum consequat lacinia tempus, duis phasellus venenatis pulvinar mauris vehicula suscipit a. Neque rutrum erat arcu volutpat tortor fames leo vestibulum iaculis curae porta sociosqu, sagittis tincidunt lectus mi nec morbi parturient mus metus dictumst aptent vel, sodales accumsan penatibus cras porttitor nisl montes ullamcorper ornare non urna.\r\n\r\nLacus venenatis at morbi feugiat purus accumsan lectus enim pulvinar quis augue sociosqu, porta luctus montes metus felis mauris aliquam arcu leo vivamus facilisis, sed viverra suspendisse sapien blandit commodo scelerisque molestie libero cras ultrices. Quis feugiat semper gravida aliquam sapien blandit at penatibus nec nibh aenean porttitor, fusce justo dapibus lacinia vitae convallis et venenatis faucibus laoreet per. Vestibulum senectus at et bibendum fames risus molestie facilisi, libero quisque lacinia nunc platea donec mattis, aliquet ligula tristique conubia mauris primis metus.",
                ViewCount = 15,
                CategoryId = Guid.Parse("73CDF461-2E7B-42D8-9FC3-AE5525A5116B"),
                ImageId = Guid.Parse("9849715D-6968-4A5E-B468-638E8F4B556E"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio dolor sit amet consectetur adipiscing elit mattis cras, sed etiam sodales mus pretium dapibus magna varius ut, tellus euismod eget dis porta magnis lacinia ac. Nascetur iaculis interdum facilisi donec nunc hendrerit sem integer vestibulum, ad proin ultrices magna cum consequat lacinia tempus, duis phasellus venenatis pulvinar mauris vehicula suscipit a. Neque rutrum erat arcu volutpat tortor fames leo vestibulum iaculis curae porta sociosqu, sagittis tincidunt lectus mi nec morbi parturient mus metus dictumst aptent vel, sodales accumsan penatibus cras porttitor nisl montes ullamcorper ornare non urna.\r\n\r\nLacus venenatis at morbi feugiat purus accumsan lectus enim pulvinar quis augue sociosqu, porta luctus montes metus felis mauris aliquam arcu leo vivamus facilisis, sed viverra suspendisse sapien blandit commodo scelerisque molestie libero cras ultrices. Quis feugiat semper gravida aliquam sapien blandit at penatibus nec nibh aenean porttitor, fusce justo dapibus lacinia vitae convallis et venenatis faucibus laoreet per. Vestibulum senectus at et bibendum fames risus molestie facilisi, libero quisque lacinia nunc platea donec mattis, aliquet ligula tristique conubia mauris primis metus.",
                ViewCount = 15,
                CategoryId = Guid.Parse("67966216-8006-46E1-ABA2-BEFBFCC8BE13"),
                ImageId = Guid.Parse("8D9A4895-7412-4162-AC2A-732FDCC4D28F"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            }

            );
        }
    }
}
