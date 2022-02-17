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
    public class WriterManager: IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer t)
        {
            _writerDal.Add(t);
        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            Writer writer = _writerDal.GetById(id);
            return writer;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public Writer Login(string email, string password)
        {
            Writer w =_writerDal.Login(email, password);
            return w;
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
        }
    }
}
