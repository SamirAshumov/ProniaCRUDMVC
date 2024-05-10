using Pronia.Business.Services.Abstracts;
using Pronia.Core.Models;
using Pronia.Core.RepositoryAbstracts;


namespace Pronia.Business.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task AddCategory(Category category)
        {
            if (!_categoryRepository.GetAll().Any(x => x.Name == category.Name))
            {
                await _categoryRepository.AddAsync(category);
                await _categoryRepository.CommitAsync();
            }         
        }

        public void DeleteCategory(int id)
        {
            Category category = _categoryRepository.Get(x => x.Id == id);

            if (category == null) throw new NullReferenceException("Kateqoriya movcud deyil...");

            _categoryRepository.Delete(category);
            _categoryRepository.Commit();
        }

        public List<Category> GetAllCategories(Func<Category, bool>? predicate = null)
        {
            return _categoryRepository.GetAll(predicate);
        }

        public Category GetCategory(Func<Category, bool>? predicate = null)
        {
            return _categoryRepository.Get(predicate);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            Category category = _categoryRepository.Get(x => x.Id == id);

            if (category == null) throw new NullReferenceException("Kateqoriya movcud deyil...");

            if (!_categoryRepository.GetAll().Any(x => x.Name == category.Name))
            {
                category.Name = newCategory.Name;
            }
            _categoryRepository.Commit();
        }
    }
}
