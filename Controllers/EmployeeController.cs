using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nowadays.Models;

namespace Nowadays.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    IEmployeeRepository employeeRepository = new EmployeeRepository();

    /// <summary>
    /// Use this to get a list of all employees
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("GetAllEmployees")]
    public IEnumerable<Employee> GetAllEmployees()
    {
        return employeeRepository.GetAllEmployees();

    }

    [HttpGet]
    [Route("GetEmployee")]
    public Employee GetEmployee(int employeeID)
    {
        return employeeRepository.GetEmployee(employeeID);
    }

    [HttpPost]
    [Route("AddEmployee")]
    public Employee AddEmployee(Employee Employee)
    {
        return employeeRepository.Add(Employee);
    }

    [HttpPost]
    [Route("UpdateEmployee")]
    public Employee UpdateEmployee(Employee employee)
    {
        return employeeRepository.Update(employee);
    }

    [HttpDelete]
    [Route("DeleteEmployee")]
    public Employee DeleteEmployee(int employeeID)
    {
        return employeeRepository.Delete(employeeID);
    }

}
