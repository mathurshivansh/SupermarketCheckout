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
                    totalPrice += 50;
                    itemCountA++;
                    break;
                case "B":
                    totalPrice += 30;
                    itemCountB++;
                    break;
                case "C":
                    totalPrice += 20;
                    itemCountC++;
                    break;
                case "D":
                    totalPrice += 15;
                    itemCountD++;
                    break;

            }
        }
        public int GetTotalPrice()
        {
            int total = totalPrice;
            total -= (itemCountA / 3) * 20;
            total -= (itemCountB / 2) * 15;

            return total;
        }
    }
}