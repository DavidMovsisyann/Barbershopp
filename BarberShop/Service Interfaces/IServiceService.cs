using Barbershopp.Entities;

namespace Barbershopp.Service_Interfaces
{
    public interface IServiceService
    {
        Task AddService(ServiceEntity Service);
        Task UpdateService(ServiceEntity Service);
        Task DeleteService(ServiceEntity Service);
        Task<ServiceEntity> GetServiceById(int id);
        Task<IEnumerable<ServiceEntity>> GetServices();
    }
}
