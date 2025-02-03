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
    }
}