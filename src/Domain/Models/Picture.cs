using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
  public class Picture
  {
    public Picture()
    {
      this.Categories = new List<Category>();
    }

    public int Id { get; set; }
    public byte[] PictureBinary { get; set; }
    public string MimeType { get; set; }
    public bool IsTransient { get; set; }
    public System.DateTime UpdatedOnUtc { get; set; }
    public virtual ICollection<Category> Categories { get; set; }
  }
}
