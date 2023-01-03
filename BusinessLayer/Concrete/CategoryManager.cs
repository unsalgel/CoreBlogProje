using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{  //category için oluşturduğun özel methodları ICategoryService sayesinde kullanabilirsin
    public class CategoryManager : IGenericService<Category>,ICategoryService
    {
        /*/EfCategoryRepository'den türetmeme sebebimiz başka bir Framework'e geçileceği zaman
        daha az kod güncelleyip yeni  framework'e daha kolay adapte etmek   EfCategoryRepositoryden
        miras alınsaydı güncelleyeceğimiz kod sayısı artıcaktı EntityFramework'e bağımlı kalıcaktık.
         */
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public List<Category> CategoryList()
        {
            return _categoryDAL.GetListAll(p=>p.CategoryStatus==true);
        }

        public Category GetById(int id)
        {
           return _categoryDAL.GetById(id);    
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetListAll();
        }

        public void Remove(Category t)
        {
            _categoryDAL.Delete(t);
        }


        public void Update(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
