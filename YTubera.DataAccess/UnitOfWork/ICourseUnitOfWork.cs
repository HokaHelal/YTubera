using System.Collections.Generic;
using System.Threading.Tasks;
using YTubera.Model;

namespace YTubera.DataAccess.UnitOfWork
{
    public interface ICourseUnitOfWork
    {
        Task<Course> GetCourseById(int id);
        IEnumerable<Course> GetMainPageCourses();
    }
}