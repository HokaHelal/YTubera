using GenericRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTubera.Core.Repositories;
using YTubera.DataAccess.Repositories;
using YTubera.Model;

namespace YTubera.DataAccess.UnitOfWork
{
    public class CourseUnitOfWork : IUnitOfWork, ICourseUnitOfWork
    {

        public ICourseRepository _courseRepository;
        private DataContext _ctx;

        public CourseUnitOfWork(DataContext dataContext)
        {
            _ctx = dataContext;
            _courseRepository = new CourseRepository(_ctx);
        }

        public IEnumerable<Course> GetMainPageCourses()
        {
            return _courseRepository.GetCoursesWithAuthor();
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseRepository.GetCourseDetailsById(id);
        }
        public async Task<int> CommitAsync()
        {
            return await _ctx.SaveChangesAsync();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
