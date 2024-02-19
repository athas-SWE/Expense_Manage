using Expenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Repositories
{
	public interface IExpensesRepository
	{
		IEnumerable<ExpenseModel> GetAllExpenses();

		IEnumerable<ExpenseModel> Search(string searchString);

		void Add(ExpenseModel expense);

		int Update(ExpenseModel expense);

		ExpenseModel GetExpenseById(int id);

		void Delete(int id);
	}
}
