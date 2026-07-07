using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class MembersController : Controller
	{
		private readonly IWebHostEnvironment _env;
		public MembersController(IWebHostEnvironment env)
		{
			_env = env;
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(MemberVM vm)
		{
			if (ModelState.IsValid == false)
			{
				return View(vm);
			}

			#region 上傳檔案
            //驗證上傳檔案
			//是否有上傳
			//檔案大小限制
			//副檔名
			//若是圖片,檢查width, height

			var path = Path.Combine(_env.WebRootPath, "Files");
			string newfileName = GetUniqueFileName(path,vm.Photo.FileName);

			var filePath = Path.Combine(path, newfileName);
			//todo是需要,縮成多種尺寸,存到不同資料夾
			using (var stream = new FileStream(filePath, FileMode.Create))
			{
				await vm.Photo.CopyToAsync(stream);
			}
			#endregion

			//  todo 新增紀錄, 生成DTO,傳給Service object
			return View();
		}

		private string GetUniqueFileName(string path, string fileName)
		{
			// 取得副檔名
			var ext = Path.GetExtension(fileName);

			string newFileName = Guid.NewGuid().ToString("N") + ext;
			
			return newFileName;
		}
	}
}
