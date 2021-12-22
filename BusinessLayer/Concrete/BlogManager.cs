using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _BlogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _BlogDal = blogDal;
        }

        public void Add(Blog t)
        {
            _BlogDal.Add(t);
        }

        public void Delete(Blog t)
        {
            _BlogDal.Delete(t);
        }

        public Blog GetById(int id)
        {
            return _BlogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _BlogDal.GetListAll();
        }

        public List<Blog> GetListWithCategory()
        {
            return _BlogDal.GetListWithCategory();
        }

        public void Update(Blog t)
        {
            _BlogDal.Update(t);
        }
    }
}
