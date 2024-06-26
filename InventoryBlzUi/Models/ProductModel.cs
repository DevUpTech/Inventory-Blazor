// Code generated by DevUp technologies, 11/12/2023 17:29:00
using System.ComponentModel.DataAnnotations;
namespace InventoryBlzUi.Models
{
    public class ProductModel
    {
		public System.Int64 Id { get; set; }
		public System.DateTime ProductionDate { get; set; }
		[Required(ErrorMessage = "Name is required.")]
		public System.String Name { get; set; }
		[Required(ErrorMessage = "NetPrice is required.")]
		public System.Decimal NetPrice { get; set; }
		[Required(ErrorMessage = "SalesPrice is required.")]
		public System.Decimal SalesPrice { get; set; }
		[Required(ErrorMessage = "StockQuantity is required.")]
		public System.Double StockQuantity { get; set; }
		[Required(ErrorMessage = "CategoryId is required.")]
		public Nullable<System.Int32> CategoryId { get; set; }
		[Required(ErrorMessage = "Status is required.")]
		public Nullable<System.Int32> Status { get; set; }

	}
}

