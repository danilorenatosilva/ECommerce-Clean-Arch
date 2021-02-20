using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	public class Category
	{
		public int Id { get; set; }
		public int? IdCategory { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
