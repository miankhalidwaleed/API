﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestAPI.Modal;
using UnitTestAPI.Models;

namespace UnitTestAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		IEmployeeRecords empRecords;
		public EmployeeController(IEmployeeRecords empInterface)
		{
			empRecords = empInterface;
		}
		[Route("getAllEmployee")]
		[HttpGet]

		public IList<Employee> getAllEmployee()
		{
			var result =  empRecords.getAllEmployee();
			return result;
		}
		[Route("getAllEmployeeById/{id}")]
		[HttpGet]
		public Employee getAllEmployeeById(string id)
		{
			return empRecords.getAllEmployeeById(id);
	
		}

		[HttpPost]
		public IActionResult Add(string name)
		{
	
			return Ok();

		}
		[Route("AddEmployee")]
		[HttpPost]
		//[ServiceFilter(typeof(ClientIpCheckActionFilter))]
		public IActionResult AddEmployee(Employee employee)
		{
			try
			{


				empRecords.AddEmployee(employee);
				return StatusCode(200, "Employee Added");
			}
			catch (Exception ex)
			{
				return StatusCode(400, ex.Message);
			}

		}
		[HttpPut]
		[Route("AddEmployee")]
		public IActionResult updateEmployee(Employee employee)
		{
			try
			{


				empRecords.AddEmployee(employee);
				return StatusCode(200, "Employee Added");
			}
			catch (Exception ex)
			{
				return StatusCode(400, ex.Message);
			}

		}
		private int getSum(int a , int b)
		{
			return a + b;
		}
	}
}
