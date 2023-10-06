using BarberShopp.Entities;

namespace BarberShopp.Service_Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeEntity employee);
        Task UpdateEmployee(EmployeeEntity employee);
        Task DeleteEmployee(EmployeeEntity employee);
        Task<EmployeeEntity> GetEmployeeById(int id);
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeeByName(string name);
    }
}
