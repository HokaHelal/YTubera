using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Core.Repositories;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public SectionRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
