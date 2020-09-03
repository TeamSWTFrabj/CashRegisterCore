using System;
using NUnit.Framework;

namespace CashRegister.Test.Unit
{
    [TestFixture]
    public class TestRegister
    {
        [Test]
        public void AddItem_OneItem_NItemsIsCorrect()
        {
            // Arrange
            var uut = new Register();

            // Act
            uut.AddItem(45.0);

            // Assert
            Assert.That(uut.GetNItems(), Is.EqualTo(1));
        }

        [TestCase(45.0)]
        [TestCase(0.0)]
        [TestCase(0.13)]
        public void AddItem_OneItem_TotalIsCorrect(double itemPrice)
        {
            // Arrange
            var uut = new Register();

            // Act
            uut.AddItem(itemPrice);

            // Assert
            Assert.That(uut.GetTotal(), Is.EqualTo(itemPrice).Within(0.005));
        }


    }
}
