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
    public class CommentManager : IGenericService<Comment>, ICommentService
    {
        ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void Add(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public Comment GetById(int id)
        {
            return _commentDAL.GetById(id);
        }

        public List<Comment> GetCommentList()
        {
            return _commentDAL.GetListComment();
        }

        public List<Comment> GetCommentListALL(int id)
        {
            return _commentDAL.GetListAll(p => p.BlogID == id).Where(p=>p.CommentStatus==true).ToList();
        }

        public List<Comment> GetList()
        {
            return _commentDAL.GetListAll();
        }

        public void Remove(Comment t)
        {
            _commentDAL.Delete(t);
        }

        public void Update(Comment t)
        {
            _commentDAL.Update(t);
        }
    }
}
