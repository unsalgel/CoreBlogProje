using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDAL _writerUserDAL;

        public WriterUserManager(IWriterUserDAL writerUserDAL)
        {
            _writerUserDAL = writerUserDAL;
        }

        public void Add(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public WriterUser GetById(int id)
        {
            return _writerUserDAL.GetById(id);
        }

        public List<WriterUser> GetList()
        {
          return  _writerUserDAL.GetListAll();    
        }

        public void Remove(WriterUser t)
        {
            _writerUserDAL.Delete(t);
        }

        public void Update(WriterUser t)
        {
           _writerUserDAL.Update(t);
        }
    }
}
