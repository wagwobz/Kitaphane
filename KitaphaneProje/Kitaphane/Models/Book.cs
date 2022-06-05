using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaphane.Models
{
    public class Book
    {

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string PublisherName { get; set; }

        [ForeignKey("PublisherName")]
        public Publisher Publisher { get; set; }

        public string AuthorName { get; set; }

        [ForeignKey("AuthorName")]
        public Author Author { get; set; }

        public ICollection<OrderBook> Orders { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price {get; set; }

        public int Stock { get; set; }

        public int Year { get; set; }

        [Display (Name = "Image")]
        public string imageURL { get; set; }

    }
}
