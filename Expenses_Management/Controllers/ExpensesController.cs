using Expenses.DataAccess.Repositories;
using Expenses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenses_Management.Controllers
{
	public class ExpensesController : Controller

	{
		private readonly IExpensesRepository _expense;

		public ExpensesController(IExpensesRepository expense)
		{
			_expense = expense;
		}

		public IActionResult Index(string searching)
		{
			List<ExpenseModel> lists = new List<ExpenseModel>();

			if (string.IsNullOrEmpty(searching)) 
			{ 
			lists = _expense.GetAllExpenses().ToList();
			}
            else
            {
				lists = _expense.Search(searching).ToList();
            }

            return View(lists);
		}
	}
}
