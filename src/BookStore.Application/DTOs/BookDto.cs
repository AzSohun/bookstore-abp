using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DTOs
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author {  get; set; }= string.Empty;
        public decimal Price { get; set; }
    }

    public class CreateUpdateBookDto
    {
        public string Title { get; set;} = string.Empty;
        public string Author { get; set;} = string.Empty;
        public decimal Price { get; set;}
    }
}
