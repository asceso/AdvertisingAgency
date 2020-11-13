using Newtonsoft.Json;

namespace Infrastructure.Models
{
    public class SettingsModel
    {
        [JsonIgnore]
        public string ConnectionString { get => $"Provider={Provider} Data Source={DataSource}"; }

        public string Provider { get; set; }
        public string DataSource { get; set; }
    }
}
