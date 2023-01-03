﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WriterUser:IdentityUser<int>
    {
 
        public string Name { get; set; }
        public string About { get; set; }
        public string ImageURL { get; set; }
        public List<Blog> Blogs { get; set; } 






    }
}
