using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestAPI.Models;

namespace UnitTestAPI.Modal
{
	public class EmployeeRecords : IEmployeeRecords
	{
		DBContext _context;
		private readonly IServiceProvider _provider;
		public EmployeeRecords(IServiceProvider serviceProvider)
		{
			_provider = serviceProvider;
			using (IServiceScope scope = _provider.CreateScope())
				_context = scope.ServiceProvider.GetRequiredService<DBContext>();
		}
		public void AddEmployee(Employee emp)
		{
			_context.Add(emp);
			_context.SaveChanges();
		}

		public IList<Employee> getAllEmployee()
		{
			IList<Employee> emplist = new List<Employee>();
			try
			{
				 emplist = _context.Employees.ToList();
				
			}
			catch
			{
               
			}
			return emplist;
		}

		public Employee getAllEmployeeById(string EmployeeId)
		{
			long EId = long.Parse(EmployeeId);
			return _context.Employees.Where(x => x.EmployeeId == EId).FirstOrDefault();
		}
	}
}
