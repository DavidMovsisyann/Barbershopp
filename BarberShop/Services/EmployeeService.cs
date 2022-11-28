using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Barbershopp.Service_Interfaces;

namespace Barbershopp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddEmployee(EmployeeEntity employee)
        {
             _unitOfWork.Employee.Insert(employee);
        }

        public async Task DeleteEmployee(EmployeeEntity employee)
        {
            await _unitOfWork.Employee.Delete(employee);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeById(int id)
        {
            var employee = await _unitOfWork.Employee.Get(x => x.Id == id);
            return employee;
        }

        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            var employees = await _unitOfWork.Employee.GetAll(x => x.Id > 0, 0, null);
            return employees;
        }

        public async Task UpdateEmployee(EmployeeEntity employee)
        {
            await _unitOfWork.Employee.Update(employee);
            await _unitOfWork.CompleteAsync();
        }
    }
}
