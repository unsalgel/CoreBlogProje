using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IGenericService<Blog>, IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void Add(Blog t)
        {
            _blogDAL.Insert(t);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDAL.GetBlogListWriter(p => p.BlogID == id);

        }

        //Blogun kategorisini getirmek için abstract methodumu buraya implement ettim.
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetBlogListWithCategory().Where(p=>p.Category.CategoryStatus==true).OrderByDescending(p => p.BlogID).ToList();
        }

        public List<Blog> GetBlogListWriter(int WriterID)
        {
            var values = _blogDAL.GetBlogListWriter(p => p.WriterID == WriterID).OrderByDescending(p=>p.BlogID).ToList();
            return values;
            //throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            return _blogDAL.GetBlogCategory(id);  
        }

        public List<Blog> GetList()
        {
            return _blogDAL.GetListAll();
        }
        public List<Blog> AdminGetList()
        {
            return _blogDAL.GetListAll().OrderByDescending(p=>p.BlogID).ToList();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDAL.GetListAll().OrderByDescending(p => p.BlogID).Take(3).ToList();
        }
        public void Remove(Blog t)
        {
            _blogDAL.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogDAL.Update(t);
        }
    }
}
