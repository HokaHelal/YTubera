using GenericRepository.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
using YTubera.Model;

namespace YTubera.Core.Repositories
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        IEnumerable<Course> GetCoursesWithAuthor();
        Task<Course> GetCourseDetailsById(int id);
    }
}