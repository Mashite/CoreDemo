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

        public List<Blog> GetBlogById(int id)
        {
            return _BlogDal.GetListAll(x => x.BlogId == id);
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

        public List<Blog> GetListWithWriter(int id)
        {
            return _BlogDal.GetListAll(x=>x.WriterId==id).ToList();
        }

        public List<Blog> GetLastByCount(int count)
        {
            return _BlogDal.GetListAll().OrderByDescending(x => x.BlogId).Take(count).ToList();
        }

        public List<Blog> GetLast3Blog()
        {
            return _BlogDal.GetListAll().OrderByDescending(p => p.BlogId).Take(3).ToList();
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            return _BlogDal.GetListWithCategoryByWriter(id);
        }
    }
}
