using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.Models
{
    class Order
    {
        public int CustomerID { get; set; }
        public DateOnly DateOnly { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }
        
    }
}
