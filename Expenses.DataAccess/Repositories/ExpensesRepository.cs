using Expenses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess.Repositories
{
	public class ExpensesRepository : IExpensesRepository
	{
		private readonly ApplicationDbContext _context;
		public void Add(ExpenseModel expense)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ExpenseModel> GetAllExpenses()
		{
			throw new NotImplementedException();
		}

		public ExpenseModel GetExpenseById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ExpenseModel> Search(string searchString)
		{
			throw new NotImplementedException();
		}

		public int Update(ExpenseModel expense)
		{
			throw new NotImplementedException();
		}
	}
}
