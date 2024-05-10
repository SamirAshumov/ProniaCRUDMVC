using Pronia.Core.Models;
using Pronia.Data.DAL;
using Pronia.Core.RepositoryAbstracts;


namespace Pronia.Data.RepositoryConcretes
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext appDbContext) : base(appDbContext)

        {
        }
    }
}
