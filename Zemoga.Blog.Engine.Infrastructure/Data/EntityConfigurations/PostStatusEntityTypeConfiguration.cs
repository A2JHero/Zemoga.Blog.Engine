using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zemoga.Blog.Engine.Domain.Posts;

namespace Zemoga.Blog.Engine.Infrastructure.Data.EntityConfigurations
{
    class PostStatusEntityTypeConfiguration : IEntityTypeConfiguration<PostStatus>
    {
        public void Configure(EntityTypeBuilder<PostStatus> entityConfiguration)
        {
            entityConfiguration.ToTable("PostStatus");
            entityConfiguration.HasKey(t => t.PostStatusId);
            entityConfiguration.Property(t => t.PostStatusId).ValueGeneratedNever();
            entityConfiguration.Property(t => t.Name).IsRequired(true).HasMaxLength(100);


            //Seed data for post status
            entityConfiguration.HasData(
                new PostStatus { PostStatusId = 0, Name = "Draft" },
                new PostStatus { PostStatusId = 1, Name = "Pending publish approval" },
                new PostStatus { PostStatusId = 2, Name = "Published" });


        }
    }
}
