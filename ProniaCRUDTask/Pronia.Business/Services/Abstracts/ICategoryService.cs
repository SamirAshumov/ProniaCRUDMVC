﻿using Pronia.Core.Models;


namespace Pronia.Business.Services.Abstracts
{
    public interface ICategoryService
    {
        Task AddCategory(Category category);
        void DeleteCategory(int id);
        void UpdateCategory(int id, Category newCategory);
        Category GetCategory(Func<Category, bool>? predicate = null);
        List<Category> GetAllCategories(Func<Category, bool>? predicate = null);

    }
}
