using GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YTubera.Core.Repositories;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private DataContext _ctx;
        public CourseRepository(DataContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCoursesWithAuthor()
        {
            return _ctx.Courses.Include(x => x.Author);
        }

        public async Task<Course> GetCourseDetailsById(int id)
        {
            return await _ctx.Courses
                .Include(x => x.Author)
                .Include(a => a.Attachments)
                .Include(x => x.Sections).ThenInclude(s => s.Lessons)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
