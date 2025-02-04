using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Category.Application.Categories.DeleteCategory
{
    public class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category == null)
            {
                return Result.Failure<Guid>(CategoryErrors.NotFound);
            }

            // Perform deletion
             _categoryRepository.DeleteAsync(category);

            // Save changes
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }

}
