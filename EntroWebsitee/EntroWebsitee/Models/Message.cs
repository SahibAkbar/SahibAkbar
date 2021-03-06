using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Phone { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        public DateTime CratedDate { get; set; }
    }
}
