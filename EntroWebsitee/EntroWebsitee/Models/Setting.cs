﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }

        [MaxLength(250)]
        public string Adress { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [MaxLength(250)]
        public string Gamil { get; set; }

        [MaxLength(250)]
        public int BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }
    }
}
