using System.Linq;

namespace ACM.BL
{
	public class CustomerRepository
	{
		public CustomerRepository()
		{
			addressRepository = new AddressRepository();
		}

		private AddressRepository addressRepository { get; set; }

		public Customer Retrieve(int customerId)
		{
			// Create the instance of the customer class
			// Pass in the requested id

			Customer customer = new Customer(customerId);

			// Temporary Hard-coded values to return
			// a populated customer

			if (customerId == 1)
			{
				customer.EmailAddress = "jsmith@mail.com";
				customer.FirstName = "Joe";
				customer.LastName = "Smith";
				customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
			}
			return customer;
		}

		///<summary>
		/// Saves the Current Customer
		/// </summary>
		///
		public bool Save(Customer customer)

		{
			// code that saved the passed in customer

			return true;
		}
	}
}