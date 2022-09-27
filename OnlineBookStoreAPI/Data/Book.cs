﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineBookStoreAPI.Data
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }
        public string BookDescription { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal BookPrice { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }

    }
}
