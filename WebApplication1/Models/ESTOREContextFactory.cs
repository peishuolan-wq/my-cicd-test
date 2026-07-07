using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebApplication1.Models.EfModels; // 確保命名空間正確

namespace WebApplication1.Models
{
	public class ESTOREContextFactory : IDesignTimeDbContextFactory<ESTOReSQL2025Context>
	{
		public ESTOReSQL2025Context CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<ESTOReSQL2025Context>();

			// 強制把連線字串塞給工具，讓它不要再去 Program.cs 找
			optionsBuilder.UseSqlServer("Server=.\\SQL2025;Database=EStoreDB202604;User ID=sa5;Password=123456;TrustServerCertificate=True;");

			return new ESTOReSQL2025Context(optionsBuilder.Options);
		}
	}
}

