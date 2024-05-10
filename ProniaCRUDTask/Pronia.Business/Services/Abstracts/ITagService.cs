using Pronia.Core.Models;


namespace Pronia.Business.Services.Abstracts
{
    public interface ITagService
    {
        Task AddTag(Tag tag);
        void DeleteTag(int id);
        void UpdateTag(int id, Tag newTag);
        Tag GetTag(Func<Tag, bool>? predicate = null);
        List<Tag> GetAllTags(Func<Tag, bool>? predicate = null);


    }
}
