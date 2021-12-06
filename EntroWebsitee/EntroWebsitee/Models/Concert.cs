using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntroWebsitee.Models
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        public DateTime CratedDate { get; set; }

        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public Image Image { get; set; }

    }
}
