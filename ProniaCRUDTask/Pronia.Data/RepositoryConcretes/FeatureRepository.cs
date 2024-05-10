
using Pronia.Core.Models;
using Pronia.Core.RepositoryAbstracts;
using Pronia.Data.DAL;


namespace Pronia.Data.RepositoryConcretes
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(AppDbContext appDbContext) : base(appDbContext)
        { 
        }
    }
}

