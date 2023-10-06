using Barbershopp.Entities;
using BarberShopp.Entities;

namespace BarberShopp.Service_Interfaces
{
    public interface IBarberServicesService
    {
        Task AddService(BarberServicesEntity Service);
        Task UpdateService(BarberServicesEntity Service);
        Task DeleteService(BarberServicesEntity Service);
        Task<BarberServicesEntity> GetServiceById(int id);
        Task<IEnumerable<BarberServicesEntity>> GetServices();
    }
}
