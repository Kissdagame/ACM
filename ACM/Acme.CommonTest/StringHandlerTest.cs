using Acme.Common;
using Xunit;
using Xunit.Abstractions;

namespace Acme.CommonTest

{
	public class StringHandlerTest
	{
		private readonly ITestOutputHelper output;

		public StringHandlerTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void InsertSpacesTestValid()
		{
			// Arrange
			var source = "NitroForce";
			var expected = "Nitro Force";

			// Act

			var actual = source.InsertSpaces();

			//Assert

			Assert.Equal(expected, actual);
			output.WriteLine(expected, actual);
		}

		[Fact]
		public void InsertSpacesTestWithExistingSpace()
		{
			//Arrange
			var source = "Nitro Force";
			var expected = "Nitro Force";

			//Act
			var actual = source.InsertSpaces();

			//Assert
			Assert.Equal(expected, actual);
			output.WriteLine(expected, actual);
		}
	}
}