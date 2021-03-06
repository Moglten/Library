using Library.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 5)]
        public string Discription { get; set; }
        [Required]
        public int AuthorId { get; set; }

        public List<Author> Authors { get; set; }

        public IFormFile File { get; set; }
        public string ImgUrl { get; set; }
    }
}