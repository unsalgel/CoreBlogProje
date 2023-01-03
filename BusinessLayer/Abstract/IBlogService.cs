using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
		//include ettigim kodla beraber blogun categorysini göstermek için  bir abstract method oluşturdum
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogByID(int id);
		List<Blog> GetBlogListWriter(int WriterID);
        List<Blog> AdminGetList(); 

    }
}
