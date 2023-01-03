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
    public class WritersMessageManager : IGenericService<WritersMessage>, IWritersMessageService
    {
        IWritersMessageDAL _writersMessageDAL;

        public WritersMessageManager(IWritersMessageDAL writersMessageDAL)
        {
            _writersMessageDAL = writersMessageDAL;
        }

        public void Add(WritersMessage t)
        {
           _writersMessageDAL.Insert(t);    
        }

        public WritersMessage GetById(int id)
        {
            return _writersMessageDAL.GetById(id);  
        }

        public List<WritersMessage> GetList()
        {
            return _writersMessageDAL.GetListAll();
        }

        public List<WritersMessage> GetListReceiverMessage(string mail)
        {
            return _writersMessageDAL.GetListAll(a => a.Receiver == mail);
        }

        public List<WritersMessage> GetListSenderMessage(string mail)
        {
            return _writersMessageDAL.GetListAll(a => a.Sender == mail);
        }

        public void Remove(WritersMessage t)
        {
            _writersMessageDAL.Delete(t);
        }

        public void Update(WritersMessage t)
        {
            _writersMessageDAL.Update(t);   
        }
    }
}
