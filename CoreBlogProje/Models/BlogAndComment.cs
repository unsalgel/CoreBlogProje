using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoreBlogProje.Models;
using EntityLayer.Concrete;

namespace CoreBlogProje.Models
{
	public class BlogAndComment
	{
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Comment> Value2 { get; set; }
     
    }
}
