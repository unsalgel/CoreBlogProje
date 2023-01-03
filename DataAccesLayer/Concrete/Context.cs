﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        //BAGLANTI CÜMLESİ 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=UNSAL\\SQLEXPRESS;database=CoreBlogDB;integrated security=true");
        }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Comment> Comments { get; set; }        
        public DbSet<Contact>Contacts { get; set; } 
        public DbSet<WritersMessage> WritersMessages { get; set; } 
        public DbSet<Writer> Writers { get; set; }  
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<ContactBox> ContactBoxes { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
         
      

    }
}
