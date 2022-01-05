using DataAccessLayer.Abstract;
using DataAccessLayer.Contrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public Writer Login(string email, string password)
        {
            using (var c = new Context())
            {
                return c.Writers.FirstOrDefault(w => w.WriterEmail == email && w.WriterPassword == password);
            }
        }
    }
}
