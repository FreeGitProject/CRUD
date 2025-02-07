using CRUD.Category.Application.Abstractions.Caching;
using CRUD.Category.Application.Abstractions.Messaging;
using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Domain.Categories;
using MediatR;

namespace CRUD.Category.Application.Categories.CreateCategory;

public class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, Guid>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, ICacheService cacheService)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
    }

    public async Task<Result<Guid>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var cat = "Categories";
        await _cacheService.RemoveAsync(cat, cancellationToken);
        var category = Domain.Categories.Category.Create(request.Name, request.Description);

         _categoryRepository.Add(category);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return category.Id;
    }
}   