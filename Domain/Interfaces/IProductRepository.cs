using System.Collections.Generic;

namespace Domain.Interfaces
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts();
		Product GetProductById(int id);
		Product Add(Product product);
		Product Update(int id, Product newProduct);
		void Delete(int id);
	}
}
