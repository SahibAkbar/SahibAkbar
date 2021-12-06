using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public DateTime CratedDate { get; set; }

        public List<About> Abouts { get; set; }

        public List<Galery> Galeries { get; set; }

        public List<Concert> Concerts { get; set; }

    }
}
