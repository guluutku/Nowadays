using System;
namespace Nowadays.Models
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Delete(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);

    }
}