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
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void Add(About t)
        {
            _AboutDal.Add(t);
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _AboutDal.GetListAll();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
