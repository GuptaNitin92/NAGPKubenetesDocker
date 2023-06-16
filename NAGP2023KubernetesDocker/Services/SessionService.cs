using NAGP2023KubernetesDocker.DB;
using NAGP2023KubernetesDocker.Models;

namespace NAGP2023KubernetesDocker.Services
{
    public class SessionService : ISessionService
    {
        private readonly ILogger<SessionService> _logger;
        private readonly IDAL _db;
        public SessionService(ILogger<SessionService> logger, IDAL db)
        {
            _logger = logger;
            _db = db;
        }
        public async Task<List<NAGPSessionData>> GetAsync()
        {
            _logger.LogDebug("Inisde Service start");

            var result = await _db.ExecuteQuery();
            return result;
        }
    }
}

