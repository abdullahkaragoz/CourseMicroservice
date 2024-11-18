using CourseMicroservice.Catalog.Api.Features.Categories;
using CourseMicroservice.Catalog.Api.Features.Courses;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CourseMicroservice.Catalog.Api.Repositories
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
