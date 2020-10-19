using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YTubera.DataAccess;
using YTubera.DataAccess.UnitOfWork;

namespace YTubera.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public ICourseUnitOfWork _courseService;
        public CourseController(ICourseUnitOfWork courseService)
        {
            _courseService = courseService;
        }
        public IActionResult GetCourses()
        {
            return Ok(_courseService.GetMainPageCourses());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var course = await _courseService.GetCourseById(id);
            return Ok(course);
        }

    }
}
