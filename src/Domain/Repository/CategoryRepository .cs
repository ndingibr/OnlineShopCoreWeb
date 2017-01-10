using System.Linq;
using Model.Infrastructure;
using Model.Models;

namespace Model.Repository
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {


    public CategoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

      public IQueryable<Category> Table { get; }
    }
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
