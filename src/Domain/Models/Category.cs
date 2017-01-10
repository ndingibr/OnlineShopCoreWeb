using System.Collections.Generic;

namespace Model.Models
{
  public class Category
    {
    public Category()
    {
      this.CategoryList = new List<Category>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? ParentCategoryId { get; set; }
    public int? PictureId { get; set; }
    public virtual ICollection<Category> CategoryList { get; set; }
    public virtual Category ParentCategory { get; set; }
    public virtual Picture Picture { get; set; }

  }
}
