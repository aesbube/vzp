using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product_quantity : Product
    {
        public int Quantity { get; set; }
        public Product_quantity(int code, string name, decimal price, int quantity) : base(code, name, price)
        {
            Quantity = quantity;
        }

        public decimal totalPrice() { return Quantity * Price; }

        public override string ToString()
        {
            return string.Format($"{Name} {Price} X {Quantity} = {totalPrice():C2}");
        }
    }
}
