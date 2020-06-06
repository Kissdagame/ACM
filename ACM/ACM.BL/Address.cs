using Acme.Common;

namespace ACM.BL
{
	public class Address : EntityBase, ILoggable
	{
		public Address()
		{
		}

		public Address(int addressId)
		{
			AddressId = addressId;
		}

		public string StreetLine1 { get; set; }
		public string StreetLine2 { get; set; }
		public string City { get; set; }
		public string StateProvince { get; set; }
		public string PostalCode { get; set; }
		public int Addresstype { get; set; }
		public int AddressId { get; private set; }

		public string Country { get; set; }

		public string Log() => $"";

		public override bool Validate()
		{
			var isValid = true;

			if (PostalCode == null) isValid = false;
			return isValid;
		}
	}
}