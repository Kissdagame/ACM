using Acme.Common;

namespace ACM.BL
{
	public class Product : EntityBase, ILoggable
	{
		public Product()
		{
		}

		public Product(int productId)
		{
			ProductId = productId;
		}

		public string ProductDesciption { get; set; }
		public decimal? CurrentPrice { get; set; }
		public int ProductId { get; private set; }

		private string _productName;

		public string ProductName
		{
			get
			{
				return _productName.InsertSpaces();
			}
			set
			{
				_productName = value;
			}
		}

		public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDesciption} Status: {EntityState.ToString()}";

		public override string ToString() => ProductName;

		///<summary>
		///VAlidate the  product data
		///</summary>

		public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}
	}
}