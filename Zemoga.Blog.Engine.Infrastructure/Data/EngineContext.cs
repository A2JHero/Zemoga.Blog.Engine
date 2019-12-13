using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using Zemoga.Blog.Engine.Common.Famework;
using Zemoga.Blog.Engine.Domain;
using Zemoga.Blog.Engine.Domain.Posts;
using Zemoga.Blog.Engine.Infrastructure.Data.EntityConfigurations;

namespace Zemoga.Blog.Engine.Infrastructure.Data
{
     public class EngineContext : DbContext, IUnitOfWork
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostStatus> PostStatus { get; set; }


        public EngineContext(DbContextOptions<EngineContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostStatusEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PostEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PostCommentEntityTypeConfiguration());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await base.SaveChangesAsync();

            return true;
        }
    }
}
