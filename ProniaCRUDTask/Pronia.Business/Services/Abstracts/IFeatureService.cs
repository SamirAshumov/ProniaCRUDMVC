using Pronia.Core.Models;


namespace Pronia.Business.Services.Abstracts
{
    public interface IFeatureService
    {
        Task AddFeature(Feature feature);
        void DeleteFeature(int id);
        void UpdateFeature(int id, Feature newFeature);
        Feature GetFeature(Func<Feature, bool>? predicate = null);
        List<Feature> GetAllFeatures(Func<Feature, bool>? predicate = null);
    }
}
