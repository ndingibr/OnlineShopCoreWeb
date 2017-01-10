using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
  public class PictureMap : EntityTypeConfiguration<Picture>
  {
    public PictureMap()
    {
      // Primary Key
      this.HasKey(t => t.Id);

      // Properties
      this.Property(t => t.MimeType)
          .IsRequired()
          .HasMaxLength(40);

      // Table & Column Mappings
      this.ToTable("Picture");
      this.Property(t => t.Id).HasColumnName("Id");
      this.Property(t => t.PictureBinary).HasColumnName("PictureBinary");
      this.Property(t => t.MimeType).HasColumnName("MimeType");
      this.Property(t => t.IsTransient).HasColumnName("IsTransient");
      this.Property(t => t.UpdatedOnUtc).HasColumnName("UpdatedOnUtc");
    }
  }
}