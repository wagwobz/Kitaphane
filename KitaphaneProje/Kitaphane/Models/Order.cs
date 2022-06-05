using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Kitaphane.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace Kitaphane.Models
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal TotalPrice { get; set; }

        public KitaphaneUser User { get; set; }

        public ICollection<OrderBook> Books { get; set; }
    }
}
