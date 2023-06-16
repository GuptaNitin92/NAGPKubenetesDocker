using NAGP2023KubernetesDocker.Models;

namespace NAGP2023KubernetesDocker.DB
{
    public interface IDAL
    {
        public Task<List<NAGPSessionData>> ExecuteQuery();
    }
}
