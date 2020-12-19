using System;
using System.Collections.Generic;
using System.Text;
using UnitTestAPI.Modal;
using UnitTestAPI.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestAPI
{
	class EmployeeRecordsTest : IEmployeeRecords
	{
		private readonly List<Employee> _EmpRecords;
		public EmployeeRecordsTest()
		{

			//datetime dt = 
			_EmpRecords = new List<Employee>()
			{
				new Employee(){ EmployeeId = 2 , DateOfBirth = new DateTime(1990,02,20), Email = "EmailTest@gmail.com", FirstName = "Waleed", LastName = "Jr" , PhoneNumber = "568244585" },
				new Employee(){ EmployeeId = 3 , DateOfBirth = new DateTime(1990,02,21), Email = "EmailTest3@gmail.com", FirstName = "James", LastName = "Jr" , PhoneNumber = "4698244585" }
			};
		}
		public void AddEmployee(Employee emp)
		{
			_EmpRecords.Add(emp);
		}

		public IList<Employee> getAllEmployee()
		{
			//var Emplist = context.Employees.ToList();
			List<Employee> Emplist = new List<Employee>();
			try
			{
				var contextOptions = new DbContextOptionsBuilder<DBContext>().UseSqlServer(@"server=DESKTOP-MQD5NT6\SQLEXPRESS;database=POS;User ID=sa;password=Netsolpk321;").Options;
				using (var context = new DBContext(contextOptions))
					Emplist = context.Employees.ToList();
			}
			catch(Exception ex)
			{

			}
			return Emplist;
		}

		public Employee getAllEmployeeById(string EmployeeId)
		{
			long EId = long.Parse(EmployeeId);
			return _EmpRecords.Where(x => x.EmployeeId == EId).FirstOrDefault();
		}
	}
}
