using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreAPI.Models
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public decimal BookPrice { get; set; }
        public AuthorDTO Author { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        public IFormFile BookImage { get; set; }
        public string BookImagePath { get; set; }


    }
}
