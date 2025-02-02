using CRUD.Category.Domain.Categories;
using System.Data;
using CRUD.Category.Infrastructure;
using Dapper;

namespace CRUD.Categoy.Infrasturcture.Repositories;

internal sealed class CategoryRepository : Repository<Category.Domain.Categories.Category>,ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category.Domain.Categories.Category>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Category.Domain.Categories.Category> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Category.Domain.Categories.Category category)
    {
        throw new NotImplementedException();
    }

    //Task ICategoryRepository.AddAsync(Category.Domain.Categories.Category category)
    //{
    //    throw new NotImplementedException();
    //}
}