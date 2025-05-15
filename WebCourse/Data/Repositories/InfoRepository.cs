using Microsoft.EntityFrameworkCore;
using WebCourse.Data.Interfaces;
using WebCourse.Data.models;
using System.Collections.Generic;
using System.Linq;

namespace WebCourse.Data.Repositories
{
	public class InfoRepository : IAllAbillities
	{

		private readonly AppDBContent appDBcontent;

		public InfoRepository(AppDBContent appDBContent)
		{
			this.appDBcontent = appDBContent;
		}
		public IEnumerable<Info> Infos => appDBcontent.Info.Include(c => c.Category);

		public Info getObjectInfo(int id) => appDBcontent.Info.FirstOrDefault(predicate: p => p.Id == id);
	}
}
