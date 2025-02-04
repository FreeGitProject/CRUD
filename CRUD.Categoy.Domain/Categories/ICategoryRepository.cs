using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Domain.Categories
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
       // Task<IEnumerable<Category>> GetAllAsync();
        void AddAsync(Category category);
        //Task UpdateAsync(Category category);
        Task DeleteAsync(Guid id);
    }
}
