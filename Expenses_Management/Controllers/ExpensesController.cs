using Expenses.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Expenses_Management.Controllers
{
	public class ExpensesController : Controller

	{
		private readonly IExpensesRepository _expense;
		public IActionResult Index()
		{
			return View();
		}
	}
}
