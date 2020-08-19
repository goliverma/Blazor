using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManag.Api.Models;
using EmployeeManag.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManag.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController(IEmployeeRepository context)
        {
            this.Context = context;
        }

        public IEmployeeRepository Context { get; }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            try{
                return Ok(await Context.GetEmployees());
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Search(string name, Gender gender)
        {
            try
            {
                var data = await Context.Search(name, gender);
                if(data.Any())
                {
                    return Ok(data);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try{
                var result = await Context.GetEmployee(id);
                if(result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try{
                if(employee == null)
                {
                    return BadRequest();
                }
                var emp = await Context.GetEmployeeEmail(employee.Email);
                if(emp != null)
                {
                    ModelState.AddModelError("email","Employee Email already use");
                    return BadRequest();
                }
                var data = await Context.AddEmployee(employee);
                return CreatedAtAction(nameof(GetEmployee),new {id = data.EmployeeId}, data);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if(id != employee.EmployeeId)
                {
                    return BadRequest("Id is Mismatch");
                }
                var emp = await Context.UpdateEmployee(employee);
                return emp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var emp = await Context.GetEmployee(id);
                if(emp == null)
                {
                    return NotFound($"Employee with Id={id} not found");
                }
                return emp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error Retrieving data from database");
            }
        }
    }
}