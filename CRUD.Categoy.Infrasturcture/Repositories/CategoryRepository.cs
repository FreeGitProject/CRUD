using CRUD.Category.Domain.Categories;
using System.Data;
using CRUD.Category.Infrastructure;
using Dapper;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using CRUD.Category.Domain.Abstractions;

namespace CRUD.Categoy.Infrasturcture.Repositories;

internal sealed class CategoryRepository : Repository<Category.Domain.Categories.Category>,ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        
    }

    public Task DeleteAsync(Guid id)
    {
        var category =  GetByIdAsync(id);
        if (category != null)
        {
            DbContext.Remove(category);
        }
        else
        {
            throw new KeyNotFoundException($"Category with ID {id} not found.");
        }
        //return Result.Success();
        return Task.CompletedTask;
    }


  
}