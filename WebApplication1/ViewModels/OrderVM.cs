using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebApplication1.ViewModels
{
	public class OrderVM
	{
		public int ID { get; set; }
		[Display(Name = "客戶姓名")]

		public string MemberName { get; set; }

		[Display(Name = "訂單時間")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]

		public DateTime OrderTime { get; set; }

		[Display(Name = "總金額")]
		public decimal Total { get; set; }


	}
}
