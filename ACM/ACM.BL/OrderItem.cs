using System.Collections.Generic;

namespace ACM.BL
{
	public class OrderItem : EntityBase
	{
		public OrderItem()
		{
		}

		public OrderItem(int orderItemId)
		{
			OrderItemId = orderItemId;
		}

		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal? PurchasePrice { get; set; }
		public int OrderItemId { get; private set; }

		///<summary>
		///Retrieve one order item.
		///</summary>
		///
		public OrderItem Retrieve(int orderItemId)
		{
			//code that retrieved the defined order item
			return new OrderItem();
		}

		///<summary>
		///Retrieve all order items.
		///</summary>
		///

		public List<OrderItem> Retrieve()
		{
			//code that retrieves all orders

			return new List<OrderItem>();
		}

		///<summary>
		///Save the current order.
		///</summary>
		public bool Save()
		{
			// Code that saved the defined customer

			return true;
		}

		///<summary>
		///VAlidate the current order.
		///</summary>
		///
		public override bool Validate()
		{
			var isValid = true;
			if (PurchasePrice == null) isValid = false;
			if (ProductId <= 0) isValid = false;
			if (Quantity <= 0) isValid = false;

			return isValid;
		}
	}
}