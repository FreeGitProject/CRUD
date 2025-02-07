using CRUD.Category.Application.Abstractions.Caching;
using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.UpdateCategory
{
    public class UpdateCategoryCommandHandler : ICommandHandler<UpdateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICacheService _cacheService;
        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, ICacheService cacheService)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _cacheService = cacheService;
        }

        public async Task<Result> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var cat = $"Categories-{request.CategoryId}";
            await _cacheService.RemoveAsync(cat, cancellationToken);
            // Fetch the category from the repository
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category == null)
            {
                return Result.Failure<Guid>(CategoryErrors.NotFound);
            }

            // Update the category's properties
            category.Update(request.Name, request.Description);

          //  _categoryRepository.UpdateAsync(category);
            // Save changes
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }

}
