﻿using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class CourseAttachmentRepository : GenericRepository<CourseAttachment>
    {
        public CourseAttachmentRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
