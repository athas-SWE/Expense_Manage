﻿using Expenses.Models;
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

		public ExpensesRepository(ApplicationDbContext context) 
		{ 
			_context = context;
		}

		public void Add(ExpenseModel expense)
		{

			try
			{
				_context.ExpensesTable.Add(expense);
				_context.SaveChanges();
			}
			catch (Exception) 
			{
				throw;
			}
			
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ExpenseModel> GetAllExpenses()
		{
			try
			{
				var expenses = _context.ExpensesTable.ToList();
				return expenses;
			}
			catch (Exception) 
			{
				throw;
			}
			
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
