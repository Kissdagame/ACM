using ACM.BL;
using Xunit;

namespace ACM.BLTest
{
	public class CustomerTest
	{
		[Fact]
		public void FullNameTestValid()
		{
			Customer customer = new Customer
			{
				FirstName = "Joe",
				LastName = "Smith"
			};

			string expected = "Smith, Joe";

			//Act

			string actual = customer.FullName;

			//Assert

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FullNameFirstNameEmpty()
		{
			Customer Customer = new Customer
			{
				LastName = "Smith"
			};
			string expected = "Smith";

			//--Act

			string actual = Customer.FullName;

			//--Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void FullNameLastNameEmpty()
		{
			Customer Customer = new Customer
			{
				FirstName = "Joe"
			};
			string expected = "Joe";

			//--Act

			string actual = Customer.FullName;

			//--Assert
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void StaticTest()
		{
			//-- Arrange
			var c1 = new Customer();
			c1.FirstName = "Joe";
			Customer.InstanceCount += 1;

			var c2 = new Customer();
			c2.FirstName = "Jim";
			Customer.InstanceCount += 1;

			var c3 = new Customer();
			c3.FirstName = "Jack";
			Customer.InstanceCount += 1;

			//--Act

			//--Assert
			Assert.Equal(3, Customer.InstanceCount);
		}

		[Fact]
		public void ValidateValid()
		{
			//--Arrange
			var customer = new Customer
			{
				LastName = "Smith",
				EmailAddress = "jsmith@mail.com"
			};
			var expected = true;

			//--Act
			var acutal = customer.Validate();

			//--Assert
			Assert.Equal(expected, acutal);
		}

		[Fact]
		public void ValidateMissingLastName()
		{
			//-- Arrange
			var customer = new Customer
			{
				EmailAddress = "jsmith@mail.com"
			};
			var expected = false;

			//-- Act
			var actual = customer.Validate();

			//--Assert

			Assert.Equal(expected, actual);
		}
	}
}