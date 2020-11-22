using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Infrastructure.Models
{
    public class SettingsModel : ICloneable
    {
        #region connection

        [JsonIgnore]
        public string ConnectionString
            => Password.Equals(string.Empty) ?
            $"Provider={Provider} Data Source={DataSource}" :
            $"Provider={Provider} Data Source={DataSource}; Jet OLEDB:Database Password={Password}";
        public string Provider { get; set; }
        public string DataSource { get; set; }
        public string Password { get; set; }

        #endregion connection

        #region application

        public bool HideBorderMenu { get; set; }
        public bool RestoreBorderMenu { get; set; }
        public bool ShowAdditionalInfo { get; set; }
        public bool ShowOnlyOwnRequests { get; set; }
        public int CloseViewButtonPosition { get; set; }
        public int FullScreenAtStart { get; set; }
        public string FileFolderPath { get; set; }
        public Dictionary<Guid, List<Guid>> RolePositionsDictionary { get; set; }

        #endregion application

        public object Clone() => MemberwiseClone();
    }
}
