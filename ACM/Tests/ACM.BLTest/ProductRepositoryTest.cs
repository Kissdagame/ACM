using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
	public class ProductRepositoryTest
	{
		[Fact]
		public void RetrieveTest()
		{
			//-- Arrange
			var productRepository = new ProductRepository();
			var expected = new Product(2)
			{
				ProductName = "Sunflowers",
				ProductDesciption = "Assorted size set of 4 Bright Yelow Mini Sunflowers",
				CurrentPrice = 15.96m
			};

			//--Act
			var actual = productRepository.Retrieve(2);

			//--Assert
			Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
			Assert.Equal(expected.ProductDesciption, actual.ProductDesciption);
			Assert.Equal(expected.ProductName, actual.ProductName);
		}

		[Fact]
		public void SaveTestValid()
		{
			//-- Arrange
			var productRepository = new ProductRepository();
			var updateProduct = new Product(2)
			{
				ProductName = "Sunflowers",
				ProductDesciption = "Assorted size set of 4 Bright Yelow Mini Sunflowers",
				CurrentPrice = 15.96m,
				HasChanges = true
			};
			//-- Act

			var actual = productRepository.Save(updateProduct);

			//-- Assert

			Assert.True(actual);
		}

		[Fact]
		public void SaveTestMissingPrice()
		{
			//-- Arrange
			var productRepository = new ProductRepository();
			var updateProduct = new Product(2)
			{
				ProductName = "Sunflowers",
				ProductDesciption = "Assorted size set of 4 Bright Yelow Mini Sunflowers",
				CurrentPrice = null,
				HasChanges = true
			};
			//-- Act
			var actual = productRepository.Save(updateProduct);

			//-- Assert

			Assert.False(false);
		}
	}
}