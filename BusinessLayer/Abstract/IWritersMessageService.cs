using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWritersMessageService:IGenericService<WritersMessage>
    {
        List<WritersMessage> GetListSenderMessage(string mail);
        List<WritersMessage> GetListReceiverMessage(string mail);

    }
}
