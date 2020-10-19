using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Core.Repositories;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
    {
        public LessonRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
