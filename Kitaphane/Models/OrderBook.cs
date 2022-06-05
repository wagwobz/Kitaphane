using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitaphane.Models
{
    public class OrderBook
    {
        public int BookID { get; set; }

        public Book Book { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }
    }
}
