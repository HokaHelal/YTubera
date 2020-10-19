using GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using YTubera.Core.Repositories;
using YTubera.Model;

namespace YTubera.DataAccess.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DataContext ctx) : base(ctx)
        {

        }
    }
}
