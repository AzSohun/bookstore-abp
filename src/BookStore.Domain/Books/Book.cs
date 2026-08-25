using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStore.Books
{
    public class Book: FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public decimal Price { get; set; }

        protected Book() { }

        public Book(Guid id, string title, string author, decimal price): base(id)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
