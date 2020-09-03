using CashRegister;
using NUnit.Framework;

namespace CoreCashRegister.Test.Uni
{
    public class Tests
    {
        private Register uut;
        [SetUp]
        public void Setup()
        {
            // First part of arrange
            uut = new Register();
        }

        [Test]
        public void AddItem_OneItem_NItemsIsCorrect()
        {
            // Further Arrange

            // Act
            uut.AddItem(45.0);

            // Assert
            Assert.That(uut.GetNItems(), Is.EqualTo(1));
        }

        [TestCase(45.0)]
        [TestCase(0.0)]
        [TestCase(0.13)]
        [TestCase(25)]
        public void AddItem_OneItem_TotalIsCorrect(double itemPrice)
        {
            // Further Arrange
            // Act
            uut.AddItem(itemPrice);

            // Assert
            Assert.That(uut.GetTotal(), Is.EqualTo(itemPrice).Within(0.005));
        }
    }
}