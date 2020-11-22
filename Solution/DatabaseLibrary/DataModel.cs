using System;
using System.ComponentModel;

namespace DatabaseLibrary
{
    /// <summary>
    /// Базовый класс сущностей
    /// </summary>
    public class DataModel
    {
        internal const string NotUsedProperty = "Свойство не используется";
        public virtual bool IsIgnorable { get; set; }

        [DataProperty(0, 2)]
        public virtual Guid ID { get; set; }

        [DataProperty(1, 0)]
        [Description("Название")]
        public virtual string Name { get; set; }

        [DataProperty(2, 1)]
        [Description("Описание")]
        public virtual string Description { get; set; }

        public DataModel()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
