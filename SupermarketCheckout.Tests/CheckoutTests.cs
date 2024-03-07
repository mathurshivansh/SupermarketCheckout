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
            checkout.Scan("B");
            checkout.Scan("C");
            //Assert
            Assert.AreEqual(150, checkout.GetTotalPrice());
        }

        [Test]
        public void SpecialPricing_ReturnsTotalPrice_1()
        {
            ICheckout checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            Assert.AreEqual(130, checkout.GetTotalPrice());
        }

        [Test]
        public void SpecialPricing_ReturnsTotalPrice_2()
        {
            ICheckout checkout = new Checkout();

            checkout.Scan("B");
            checkout.Scan("B");

            Assert.AreEqual(45, checkout.GetTotalPrice());
        }

        [Test]
        public void SpecialPricing_ReturnsTotalPrice_3()
        {

            ICheckout checkout = new Checkout();

            checkout.Scan("C");
            checkout.Scan("B");
            checkout.Scan("D");
            checkout.Scan("B");
            checkout.Scan("A");

            Assert.AreEqual(130, checkout.GetTotalPrice());
        }

        [Test]

        public void SpecialPricing_ReturnsTotalPrice_4()
        {
            ICheckout checkout = new Checkout();

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");

            Assert.AreEqual(210, checkout.GetTotalPrice());
        }

    }
}