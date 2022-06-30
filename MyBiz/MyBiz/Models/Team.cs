using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Models
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Motto { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
    }
}
