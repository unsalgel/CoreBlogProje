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
    public class ContactManager : IGenericService<Contact>, IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void Add(Contact t)
        {
          _contactDAL.Insert(t);    
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
          return  _contactDAL.GetListAll();    
        }

        public void Remove(Contact t)
        {
            _contactDAL.Delete(t);  
        }

        public void Update(Contact t)
        {
         _contactDAL.Update(t);
        }
    }
}
