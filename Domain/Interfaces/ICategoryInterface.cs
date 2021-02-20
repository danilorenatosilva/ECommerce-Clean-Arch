using System.Collections.Generic;

namespace Domain.Interfaces
{
	public interface ICategoryInterface
	{
		IEnumerable<Category> GetCategories();
		Category GetCategoryById(int id);
		Category Add(Category category);
		Category Update(int id, Category newCategory);
		void Delete(int id);
	}
}
