using Barbershopp.Entities;
using Barbershopp.Repository_Interfaces;
using Barbershopp.Service_Interfaces;

namespace Barbershopp.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddService(ServiceEntity service)
        {
             _unitOfWork.Service.Insert(service);
            await _unitOfWork.Service.Update(service);
        }

        public async Task DeleteService(ServiceEntity service)
        {
            await _unitOfWork.Service.Delete(service);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<ServiceEntity> GetServiceById(int id)
        {
            var service = await _unitOfWork.Service.Get(x=>x.Id == id); 
            return service;
        }

        public async Task<IEnumerable<ServiceEntity>> GetServices()
        {
            var services = await _unitOfWork.Service.GetAll(x=>x.Id>0,0,null);
            return services;
        }

        public async Task UpdateService(ServiceEntity service)
        {
            await _unitOfWork.Service.Update(service);
            await _unitOfWork.CompleteAsync();
        }
    }
}
