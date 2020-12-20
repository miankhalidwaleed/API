using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestAPI.Models;

namespace UnitTestAPI.Modal
{
	public interface IEmployeeRecords
	{
		void AddEmployee(Employee emp);
		IList<Employee> getAllEmployee();
		Employee getAllEmployeeById(string EmployeeId);
		void updateEmployee(Employee employee);
	}
}
