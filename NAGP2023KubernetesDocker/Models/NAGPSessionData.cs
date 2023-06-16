namespace NAGP2023KubernetesDocker.Models
{
    public class NAGPSessionData
    {
        public string SessionName { get;set; }
        public int SessionNumber { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionDescription { get; set; } = string.Empty;

    }
}
