using System;
using Newtonsoft.Json;

namespace Infrastructure.Models
{
    public class SettingsModel : ICloneable
    {
        #region connection

        [JsonIgnore]
        public string ConnectionString => $"Provider={Provider} Data Source={DataSource}";
        public string Provider { get; set; }
        public string DataSource { get; set; }

        #endregion connection

        #region application

        public bool HideBorderMenu { get; set; }
        public bool RestoreBorderMenu { get; set; }
        public bool ShowAdditionalInfo { get; set; }
        public int CloseViewButtonPosition { get; set; }
        public int FullScreenAtStart { get; set; }

        #endregion application

        public object Clone() => MemberwiseClone();
    }
}
