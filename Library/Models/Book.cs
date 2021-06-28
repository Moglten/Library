using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Title { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 5)]
        public string Discription { get; set; }
        public string ImgUrl { get; set; }
        public Author Author { get; set; }
    }
}