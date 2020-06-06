using ACM.BL;
using Acme.Common;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Acme.CommonTest
{
	public class LoggingServiceTest
	{
		private readonly ITestOutputHelper output;

		public LoggingServiceTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void WriteToFileTest()
		{
			// -- Arrange
			var changedItems = new List<ILoggable>();

			var customer = new Customer(1)
			{
				EmailAddress = "jsmith@mail.com",
				FirstName = "Joe",
				LastName = "Smith",
				AddressList = null
			};
			changedItems.Add(customer);
			output.WriteLine(customer.ToString());

			var product = new Product(2)
			{
				ProductName = "Sunflowers",
				ProductDesciption = "Assorted size set of 4 Bright Yelow Mini Sunflowers",
				CurrentPrice = 15.96m
			};
			changedItems.Add(product);
			output.WriteLine(product.ToString());

			//-- Act

			LoggingService.WriteToFile(changedItems);

			// --Assert
			// Nothing here to assert
		}
	}
}