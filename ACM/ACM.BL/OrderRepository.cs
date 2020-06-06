using System;

namespace ACM.BL
{
	public class OrderRepository
	{
		///<summary>
		///Retrieve one order
		///</summary>
		///
		public Order Retrieve(int orderId)
		{
			// Create the instance of the Order class
			// Pass in the requested Id

			Order order = new Order(orderId);

			// code that retrieved the defined order

			// Temporary hard- coded values to return
			// A populated order

			if (orderId == 10)
			{
				//use current year in hard-coded data

				order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
			}
			return order;
		}

		public bool Save(Order order)
		{
			// Code that saved the passed in order

			return true;
		}
	}
}