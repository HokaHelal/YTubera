using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class SectionRepository : GenericRepository<Section>
    {
        public SectionRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
