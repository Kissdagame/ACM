using ACM.BL;
using System.Collections.Generic;
using Xunit;

namespace ACM.BLTest
{
	public class CustomerRepositoryTest
	{
		[Fact]
		public void RetrieveValid()
		{
			// -- Arragne

			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "jsmith@mail.com",
				FirstName = "Joe",
				LastName = "Smith"
			};

			// --Act
			var actual = customerRepository.Retrieve(1);

			//-- Assert
			Assert.Equal(expected.CustomerId, actual.CustomerId);
			Assert.Equal(expected.EmailAddress, actual.EmailAddress);
			Assert.Equal(expected.FirstName, actual.FirstName);
			Assert.Equal(expected.LastName, actual.LastName);
		}

		[Fact]
		public void RetieveExistingWithAddress()
		{
			// -- Arrange
			var customerRepository = new CustomerRepository();
			var expected = new Customer(1)
			{
				EmailAddress = "jsmith@mail.com",
				FirstName = "Joe",
				LastName = "Smith",
				AddressList = new List<Address>()
				{
					new Address()
					{
						Addresstype = 1,
						StreetLine1 = "Bag FLow",
						StreetLine2 = "Bag row",
						City = "Phoenix",
						StateProvince = "Shire",
						Country = " Middle Earth",
						PostalCode = "456"
					},
					new Address()
					{
						Addresstype = 2,
						StreetLine1 = "FLow Run",
						StreetLine2 = "Bag SNow",
						City = "Phoenix",
						StateProvince = "Shire",
						Country = " Middle Earth",
						PostalCode = "654"
					}
				}
			};

			// -- Act

			var actual = customerRepository.Retrieve(1);

			// --Assert

			Assert.Equal(expected.CustomerId, actual.CustomerId);
			Assert.Equal(expected.EmailAddress, actual.EmailAddress);
			Assert.Equal(expected.FirstName, actual.FirstName);
			Assert.Equal(expected.LastName, actual.LastName);

			for (int i = 0; i < 1; i++)
			{
				Assert.Equal(expected.AddressList[i].Addresstype, actual.AddressList[i].Addresstype);
				Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
				Assert.Equal(expected.AddressList[i].StateProvince, actual.AddressList[i].StateProvince);
				Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
				Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
				Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
			}
		}
	}
}