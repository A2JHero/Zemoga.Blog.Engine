using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zemoga.Blog.Engine.Domain.Posts;

namespace Zemoga.Blog.Engine.Infrastructure.Data.EntityConfigurations
{
    class PostCommentEntityTypeConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> entityConfiguration)
        {
            entityConfiguration.ToTable("PostComment");
            entityConfiguration.HasKey(t => t.PostCommentId);
            entityConfiguration.Property(t => t.PostCommentId).ValueGeneratedOnAdd();
            entityConfiguration.Property(t => t.CreationtDate).IsRequired(true);
            entityConfiguration.Property(t => t.PostId).IsRequired(true);
            entityConfiguration.Property(t => t.AuthorName).IsRequired(true).HasMaxLength(100);
            entityConfiguration.Property(t => t.AuthorEmail).IsRequired(true).HasMaxLength(100);
            entityConfiguration.Property(t => t.Comment).IsRequired(true).HasMaxLength(4000);

        }
    }
}
