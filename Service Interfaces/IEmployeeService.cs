using Barbershopp.Entities;

namespace Barbershopp.Service_Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeEntity employee);
        Task UpdateEmployee(EmployeeEntity employee);
        Task DeleteEmployee(EmployeeEntity employee);
        Task<EmployeeEntity> GetEmployeeById(int id);
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
    }
}
