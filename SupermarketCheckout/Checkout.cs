using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SupermarketCheckout
{
    public class Checkout : ICheckout
    {
        private int totalPrice;
        public void Scan(string item)
        {
            switch (item)
            {
                case "A":
                    totalPrice = totalPrice + 50;
                    break;
                
            }
        }
        public int GetTotalPrice()
        {
            //
            return totalPrice;
        }
    }
}