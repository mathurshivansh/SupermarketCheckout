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
        private int itemCountA;
        private int itemCountB;
        private int itemCountC;
        private int itemCountD;
        public void Scan(string item)
        {
            switch (item)
            {
                case "A":
                    totalPrice = totalPrice + 50;
                    itemCountA++;
                    break;
                case "B":
                    totalPrice = totalPrice + 30;
                    itemCountB++;
                    break;
                case "C":
                    totalPrice = totalPrice + 20;
                    itemCountC++;
                    break;
                case "D":
                    totalPrice = totalPrice + 15;
                    itemCountD++;
                    break;
            }
        }
        public int GetTotalPrice()
        {
            int total = totalPrice;
            total = total - (itemCountA / 3) * 20;

            total = total - (itemCountB / 2) * 15;

            return total;
        }
    }
}