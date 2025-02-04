using CRUD.Category.Domain.Abstractions;
using CRUD.Category.Domain.Categories.Events;
using System;

namespace CRUD.Category.Domain.Categories
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public CategoryStatus Status { get; private set; }

        // Private constructor for existing categories
        private Category(Guid id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
            Status = CategoryStatus.Active; // Default to Active on creation

            // Raise the CategoryCreatedDomainEvent
            RaiseDomainEvent(new CategoryCreatedDomainEvent(id, name, description, Status));
        }

        // Private parameterless constructor for ORM frameworks
        private Category() { }

        // Factory method for creating a new category
        public static Category Create(string name, string description)
        {
          
            return new Category(Guid.NewGuid(), name, description);
        }

        // Update category details
        public void Update(string name, string description)
        {
            var oldName = Name;
            var oldDescription = Description;

            Name = name;
            Description = description;
            

            // Raise the CategoryUpdatedDomainEvent
            RaiseDomainEvent(new CategoryUpdatedDomainEvent(Id, oldName, name, oldDescription, description, Status));
        }

        // Activate the category
        public void Activate()
        {
            if (Status == CategoryStatus.Active)
                throw new InvalidOperationException("Category is already active.");

            Status = CategoryStatus.Active;

            // Raise the CategoryActivatedDomainEvent
            RaiseDomainEvent(new CategoryActivatedDomainEvent(Id, Status));
        }

        // Deactivate the category
        public void Deactivate()
        {
            if (Status == CategoryStatus.Inactive)
                throw new InvalidOperationException("Category is already inactive.");

            Status = CategoryStatus.Inactive;

            // Raise the CategoryDeactivatedDomainEvent
            RaiseDomainEvent(new CategoryDeactivatedDomainEvent(Id, Status));
        }
    }
}
