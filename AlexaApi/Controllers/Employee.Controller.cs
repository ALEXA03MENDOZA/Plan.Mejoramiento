using Microsoft.AspNetCore.Mvc;
using AlexaApi.Models;
using AlexaApi.Services;
using System;
using System.Collections.Generic;

namespace AlexaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("Register")]
        public IActionResult RegisterEmployee([FromBody] EmployeeModel employee)
        {
            try
            {
                _employeeService.RegisterEmployee(employee);
                return Ok(new { message = "Employee Registrado con exito." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }

        [HttpGet("GetEmployees")]
        public ActionResult<IEnumerable<EmployeeModel>> GetEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
