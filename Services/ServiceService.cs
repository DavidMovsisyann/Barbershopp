using Barbershopp.Entities;
using BarberShopp.Entities;
using BarberShopp.Repository_Interfaces;
using BarberShopp.Service_Interfaces;

namespace BarberShopp.Services
{
    public class ServiceService : IBarberServicesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddService(BarberServicesEntity service)
        {
             _unitOfWork.Service.Insert(service);
            await _unitOfWork.Service.Update(service);
        }

        public async Task DeleteService(BarberServicesEntity service)
        {
            await _unitOfWork.Service.Delete(service);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<BarberServicesEntity> GetServiceById(int id)
        {
            var service = await _unitOfWork.Service.Get(x=>x.Id == id); 
            return service;
        }

        public async Task<IEnumerable<BarberServicesEntity>> GetServices()
        {
            var services = await _unitOfWork.Service.GetAll(x=>x.Id>0,0,null);
            return services;
        }

        public async Task UpdateService(BarberServicesEntity service)
        {
            await _unitOfWork.Service.Update(service);
            await _unitOfWork.CompleteAsync();
        }
    }
}
