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
    public class ContactBoxManager : IGenericService<ContactBox>, IContactBoxService
    {
        IContactBoxDAL _contactBoxDAL;

        public ContactBoxManager(IContactBoxDAL contactBoxDAL)
        {
            _contactBoxDAL = contactBoxDAL;
        }

        public void Add(ContactBox t)
        {
            _contactBoxDAL.Insert(t);
        }

        public ContactBox GetById(int id)
        {
         return _contactBoxDAL.GetById(id);
        }

        public List<ContactBox> GetList()
        {
         return _contactBoxDAL.GetListAll();
        }

        public void Remove(ContactBox t)
        {
            throw new NotImplementedException();
        }

        public void Update(ContactBox t)
        {
          _contactBoxDAL.Update(t); 
        }
    }
}
