using System.Collections.Generic;

namespace ACM.BL
{
	public class AddressRepository
	{
		/// <summary>
		///  Retrieve one address
		/// </summary>
		///

		public Address Retrieve(int addressId)
		{
			// Create the instance of the Address Class
			//Pass in the requested Id

			Address address = new Address(addressId);

			// Code retrievee the defined address

			// Temporary hard coded values to return
			// a populated address

			if (addressId == 1)
			{
				address.Addresstype = 1;
				address.StreetLine1 = "Bag FLow";
				address.StreetLine2 = "Bag row";
				address.City = "Phoenix";
				address.StateProvince = "Shire";
				address.Country = " Middle Earth";
				address.PostalCode = "456";
			}
			return address;
		}

		public IEnumerable<Address> RetrieveByCustomerId(int customerId)
		{
			// Code that retieves the defined addressess for the custiomer

			// TEmporary hard-coded values to return
			// a set of addresses for a customer

			var addressList = new List<Address>();
			Address address = new Address(1)
			{
				Addresstype = 1,
				StreetLine1 = "Bag FLow",
				StreetLine2 = "Bag row",
				City = "Phoenix",
				StateProvince = "Shire",
				Country = " Middle Earth",
				PostalCode = "456",
			};
			addressList.Add(address);

			address = new Address(2)
			{
				Addresstype = 2,
				StreetLine1 = "FLow Run",
				StreetLine2 = "Bag SNow",
				City = "Phoenix",
				StateProvince = "Shire",
				Country = " Middle Earth",
				PostalCode = "654",
			};

			addressList.Add(address);
			return addressList;
		}

		///<summary>
		/// Saves the current Address
		/// </summary>

		public bool Save(Address address)
		{
			// code returns that saves the passed in address

			return true;
		}
	}
}