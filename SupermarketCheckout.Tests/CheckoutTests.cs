using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout.Tests

// Test Driven Development (TDD)
// Red, Green, Refactor

// Used nUnit for testing
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void ScanSingleItem_ReturnsTotalPrice()
        {
            //Arrange
            ICheckout checkout = new Checkout();

            //Act
            checkout.Scan("A");
            //Assert
            Assert.AreEqual(50, checkout.GetTotalPrice());

        }

        [Test]
        public void ScanMultipleSingleItems_ReturnsTotalPrice()
        {
            //Arrange
            ICheckout checkout = new Checkout();

            //Act
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");
            //Assert
            Assert.AreEqual(115, checkout.GetTotalPrice());
        }

        [Test]
        public void ScanMultipleSingleItems_ReturnsTotalPrice_2()
        {
            //Arrange
            ICheckout checkout = new Checkout();

            //Act
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            //Assert
            Assert.AreEqual(200, checkout.GetTotalPrice());
        }

        [Test]
        public void SpecialPricing_ReturnsTotalPrice()
        {
            ICheckout checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.AreEqual(130, checkout.GetTotalPrice());
        }
    }
}