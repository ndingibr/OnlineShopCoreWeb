using System.Linq;
using Model.Infrastructure;
using Model.Models;

namespace Model.Repository
{
    public class PictureRepository : RepositoryBase<Picture>, IPictureRepository
    {
        public PictureRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

      public IQueryable<Picture> Table { get; }
    }
    public interface IPictureRepository : IRepository<Picture>
    {
    }
}
