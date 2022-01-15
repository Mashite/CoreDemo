using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithWriter(int id);
        List<Blog> GetLastByCount(int count);
        List<Blog> GetLast3Blog();
        List<Blog> GetListWithCategoryByWriter(int id);
    }
}
 