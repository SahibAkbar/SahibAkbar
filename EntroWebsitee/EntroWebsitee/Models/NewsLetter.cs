using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Models
{
    public class NewsLetter
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(250)]
        public string Email { get; set; }

        public DateTime CratedDate { get; set; }

    }
}
