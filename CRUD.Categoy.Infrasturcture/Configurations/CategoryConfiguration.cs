using CRUD.Category.Domain.Categories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Category.Infrasturcture.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Categories.Category>
{
    public void Configure(EntityTypeBuilder<Domain.Categories.Category> builder)
    {
        // Table name
        builder.ToTable("category");

        // Primary Key
        builder.HasKey(c => c.Id);

        // Properties
        builder.Property(c => c.Id)
            .IsRequired()
            .ValueGeneratedOnAdd(); // Configures auto-generated values for the Id

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100); // Limit the Name length to 100 characters

        builder.Property(c => c.Description)
            .HasMaxLength(500); // Limit the Description length to 500 characters

        builder.Property(c => c.Status)
            .IsRequired()
            .HasConversion(
                v => v.ToString(),          // Convert Enum to string for storage
                v => (CategoryStatus)Enum.Parse(typeof(CategoryStatus), v) // Convert string to Enum
            )
            .HasMaxLength(50); // Limit the status string to 50 characters

        // Indexes (optional)
        builder.HasIndex(c => c.Name)
            .IsUnique(); // Ensures the Name is unique in the table

        // Additional configuration if needed
    }
}