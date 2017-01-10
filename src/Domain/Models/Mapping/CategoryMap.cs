using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
  public class CategoryMap : EntityTypeConfiguration<Category>
  {
    public CategoryMap()
    {
      // Primary Key
      this.HasKey(t => t.Id);

      // Properties
      this.Property(t => t.Name)
          .IsRequired()
          .HasMaxLength(400);

      // Table & Column Mappings
      this.ToTable("Category");
      this.Property(t => t.Id).HasColumnName("Id");
      this.Property(t => t.Name).HasColumnName("Name");
      this.Property(t => t.Description).HasColumnName("Description");
      this.Property(t => t.ParentCategoryId).HasColumnName("ParentCategoryId");
      this.Property(t => t.PictureId).HasColumnName("PictureId");

      // Relationships
      this.HasOptional(t => t.ParentCategory)
          .WithMany(t => t.CategoryList)
          .HasForeignKey(d => d.ParentCategoryId);
      this.HasOptional(t => t.Picture)
          .WithMany(t => t.Categories)
          .HasForeignKey(d => d.PictureId);

    }
  }
}
