using EntroWebsitee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option):base(option)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
    }
}
