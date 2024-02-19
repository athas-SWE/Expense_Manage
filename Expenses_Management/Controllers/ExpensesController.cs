using Microsoft.AspNetCore.Mvc;

namespace Expenses_Management.Controllers
{
	public class ExpensesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
