using System;

namespace ACM.BL
{
	public class ProductRepository
	{
		///<summary>
		///Retrieve one product
		///</summary>

		public Product Retrieve(int productId)
		{
			// Create the instance of the product class
			// Pass in the requested ID

			Product product = new Product(productId);

			// code that retrieves the defuned product

			// Temporary hard-coded values to return
			// a populated product
			if (productId == 2)
			{
				product.ProductName = "Sunflowers";
				product.ProductDesciption = "Assorted size set of 4 Bright Yelow Mini Sunflowers";
				product.CurrentPrice = 15.96m;
			}
			Object myobject = new Object();
			Console.WriteLine($"Object: {myobject.ToString()}");
			Console.WriteLine($"PRoduct: {product.ToString()}");
			return product;
		}

		///<summary>
		///Save the current product.
		///</summary>

		public bool Save(Product product)
		{
			var success = true;
			if (product.HasChanges)
			{
				if (product.IsValid)
				{
					if (product.IsNew)
					{
						//Call an insert stored procedure
					}
					else
					{
						//call an update store procedure
					}
				}
				else
				{
					success = false;
				}
			}
			return success;
		}
	}
}