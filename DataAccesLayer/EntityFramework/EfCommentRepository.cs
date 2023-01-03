﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> GetListComment()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(p => p.Blog).ToList();


            }
        }
    }
}
