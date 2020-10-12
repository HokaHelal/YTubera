using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class CourseRepository : GenericRepository<Course>
    {
        public CourseRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
