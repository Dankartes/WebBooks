using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBooks.Models;

namespace WebBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
        void Save();
    }
}
