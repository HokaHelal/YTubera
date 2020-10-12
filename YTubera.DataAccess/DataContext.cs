using GenericRepository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using YTubera.Model;

namespace YTubera.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
           base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAttachment> CourseAttachments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public override int SaveChanges()
        {
            var modifiedEntries =
                ChangeTracker
                    .Entries()
                    .Where(x =>
                        x.Entity is IAuditableEntity &&
                        (
                        x.State == EntityState.Added ||
                        x.State == EntityState.Modified
                        ));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    Thread.CurrentPrincipal =
                        new WindowsPrincipal(WindowsIdentity.GetCurrent());

                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity)
                            .Property(x => x.CreatedBy)
                            .IsModified = false;
                        base.Entry(entity)
                            .Property(x => x.CreatedDate)
                            .IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }
}
