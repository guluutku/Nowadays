
namespace Nowadays.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        NowadaysContext context = new NowadaysContext();

        public EmployeeRepository()
        {
        }

        Employee IEmployeeRepository.Add(Employee employee)
        {
            try
            {
                context.Add(employee);
                context.SaveChanges();
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Employee IEmployeeRepository.Delete(int employeeId)
        {
            try
            {
                Employee? employee = context.Employees.FirstOrDefault(c => c.employeeId == employeeId);
                employee!.isActive = false;
                context.SaveChanges();

                return employee;
            }
            catch
            {
                throw;
            }
        }

        List<Employee> IEmployeeRepository.GetAllEmployees()
        {
            List<Employee> employees = context.Employees.ToList();
            return employees;
        }

        Employee IEmployeeRepository.Update(Employee employee)
        {
            try
            {
                context.Update(employee);
                context.SaveChanges();
                return employee;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Employee IEmployeeRepository.GetEmployee(int employeeId)
        {
            var employee = context.Employees.FirstOrDefault(c => c.employeeId == employeeId);
            return employee!;
        }


    }
}