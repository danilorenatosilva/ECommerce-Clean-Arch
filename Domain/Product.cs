using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class Product
	{
		public string Sku { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public Category Category { get; set; }
	}
}
