using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly SieveProcessor sieveProcessor;

        public EmployeesController(ApplicationDbContext dbContext, SieveProcessor sieveProcessor)
        {
            this.dbContext = dbContext;
            this.sieveProcessor = sieveProcessor;
        
        }
        [Route("getal")]
        [HttpGet]
        public async Task<IActionResult> getal([FromQuery] SieveModel model)
        {
            var allemplo = dbContext.Employees.AsQueryable();
            allemplo = sieveProcessor.Apply(model, allemplo);
            return Ok(allemplo);
        }

        


        //return Ok(dbContext.Employees.ToList());
        //}


        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee() {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                PhoneNumber = addEmployeeDto.PhoneNumber,
                Salary = addEmployeeDto.Salary
            };
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges(); //CHANGES TRANSFERED TO DB
            return Ok(employeeEntity);

        }
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetDataonId(Guid id)
        {
            var emplo=dbContext.Employees.Find(id);
            if (emplo == null)
            {
                return NotFound();
            }
            return Ok(emplo);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmploDto updateempdto)
        {
            var emplo = dbContext.Employees.Find(id);
            if (emplo == null)
            {
                return NotFound();
            }
            emplo.Name = updateempdto.Name;
            emplo.Email = updateempdto.Email;
            emplo.PhoneNumber = updateempdto.PhoneNumber;
            emplo.Salary = updateempdto.Salary;

            dbContext.SaveChanges();
            return Ok(emplo);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var emplo = dbContext.Employees.Find(id);
            if (emplo == null)
            {
                return NotFound();
            }
            dbContext.Employees.Remove(emplo);
            dbContext.SaveChanges();
            return Ok();
        }

    }
}
