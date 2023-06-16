using NAGP2023KubernetesDocker.Models;

namespace NAGP2023KubernetesDocker.Services
{
    public interface ISessionService
    {
        public Task<List<NAGPSessionData>> GetAsync();
    }
}
