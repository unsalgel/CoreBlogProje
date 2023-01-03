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
    public class AboutManager:IGenericService<About>,IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public About GetById(int id)
        {
            return _aboutDAL.GetById(id);
        }

        public List<About> GetList()
        {
          return _aboutDAL.GetListAll();    
        }

        public void Remove(About t)
        {
            throw new NotImplementedException();
        }

        public void Update(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}
