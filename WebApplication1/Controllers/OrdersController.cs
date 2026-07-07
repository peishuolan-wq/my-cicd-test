using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.EfModels;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class OrdersController : Controller
	{
		private readonly OrderService _orderService;

		public OrdersController(OrderService orderService)
		{
			_orderService = orderService;
		}

		public IActionResult Index()
		{
			List<Order> data = _orderService.GetOrders();

			List<OrderVM> orderVMs = data.Select(o => new OrderVM
			{
				ID = o.Id,
				MemberName = o.Member.MemberName,
				OrderTime = o.OrderTime,
				Total = o.Total
			}).ToList();

			return View(orderVMs);
		}
	}
}
