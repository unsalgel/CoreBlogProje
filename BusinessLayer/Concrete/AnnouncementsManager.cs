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
    public class AnnouncementsManager : IGenericService<Announcements>
    {
        IAnnouncementsDAL _announcementsDAL;
        public AnnouncementsManager(IAnnouncementsDAL announcementsDAL)
        {
            _announcementsDAL = announcementsDAL;
        }

        public void Add(Announcements t)
        {
            _announcementsDAL.Insert(t);
        }

        public Announcements GetById(int id)
        {
            return _announcementsDAL.GetById(id);
        }

        public List<Announcements> GetList()
        {
            return _announcementsDAL.GetListAll();
        }

        public void Remove(Announcements t)
        {
            _announcementsDAL.Delete(t);
        }

        public void Update(Announcements t)
        {
            _announcementsDAL.Update(t);
        }
    }
}
