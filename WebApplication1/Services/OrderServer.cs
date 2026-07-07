using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.EfModels;
using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;    
using System.Linq;                   
using WebApplication1.Models.EfModels;

namespace WebApplication1.Services
{
	public class OrderService
	{
		public ESTOReSQL2025Context Context { get; }

		public OrderService(ESTOReSQL2025Context context)
		{
			Context = context;
		}


		public List<Order> GetOrders()
		{
			return Context.Orders.AsNoTracking()
				.Include(o => o.Member)
				.ToList();
		}
	}
}
