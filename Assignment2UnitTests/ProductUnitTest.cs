using Assignment2;

namespace Assignment2UnitTests
{
    public class Tests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _product = new Product(5, "Apple", 6, 10000);
        }

        /// <summary>
        /// Test that product ID is within the range of 5 to 50000
        /// </summary>
        /// <param name="prodID"></param>
        [TestCase(5)]
        [TestCase(25000)]
        [TestCase(50000)]
        public void ProdID_ShouldBeInRange(int prodID)
        {
            // Act
            _product.ProdID = prodID;

            // Assert
            Assert.That(_product.ProdID, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(50000));
        }

        /// <summary>
        /// Test that product name is not null, empty, whitespace or tab
        /// </summary>
        /// <param name="prodName"></param>
        [TestCase("orange")]
        [TestCase("apple")]
        [TestCase("banana")]
        public void ProdName_ShouldNotBeNullOrEmpty(string prodName)
        {
            // Act
            _product.ProdName = prodName;

            // Assert
            Assert.That(_product.ProdName, Is.Not.Null.And.Not.Empty.And.Not.EqualTo(" ").And.Not.EqualTo("\t"));
        }

        /// <summary>
        /// Test that stock amount is within the range of 5 to 500000 after increasing stock count
        /// </summary>
        /// <param name="stockAmount"></param>
        [TestCase(10)]
        [TestCase(500)]
        [TestCase(1000)]
        public void IncreaseStockCount_ShouldBeInRange(int stockAmount)
        {
            // Act
            _product.IncreaseStockCount(stockAmount);

            // Assert
            Assert.That(_product.StockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));
        }

        /// <summary>
        /// Test that stock amount is within the range of 5 to 500000 after decreasing stock count
        /// </summary>
        /// <param name="stockAmount"></param>
        [TestCase(10)]
        [TestCase(500)]
        [TestCase(1000)]
        public void DecreaseStockCount_ShouldBeInRange(int stockAmount)
        {
            // Act
            _product.DecreaseStockCount(stockAmount);

            // Assert
            Assert.That(_product.StockAmount, Is.GreaterThanOrEqualTo(5).And.LessThanOrEqualTo(500000));
        }

    }
}
