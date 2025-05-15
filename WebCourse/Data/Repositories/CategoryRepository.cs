using WebCourse.Data.Interfaces;
using WebCourse.Data.models;

namespace WebCourse.Data.Repositories
{
	public class CategoryRepository : IInformationCategory
	{
		private readonly AppDBContent appDBcontent;

		public CategoryRepository(AppDBContent appDBContent)
		{
			this.appDBcontent = appDBContent;
		}
		public IEnumerable<Category> AllCategories => appDBcontent.Category;
	}
}
