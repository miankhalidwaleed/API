using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using UnitTestAPI.Controllers;
using UnitTestAPI.Modal;
using Xunit;

namespace XUnitTestAPI
{
	public class UnitTest1
	{
		EmployeeController _controller;
		IEmployeeRecords _employeeRecords;
		public UnitTest1()
		{
			//using var scope = _ScopeFactory.CreateScope();
			//var _context = scope.ServiceProvider.GetRequiredService<DBContext>();
			//_empController = new EmployeeController(_context);
			_employeeRecords = new EmployeeRecordsTest();
			_controller = new EmployeeController(_employeeRecords);
			

		}
		[Fact]
		public void Test1()
		{

			var result = _controller.getAllEmployee();
			int K = 3;
			Assert.NotEmpty(result);

		}
	}
}
