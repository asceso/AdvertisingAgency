using System;

namespace DatabaseLibrary
{
    public class DataModel
    {
        internal const string NotUsedProperty = "Свойство не используется";
        public virtual bool IsIgnorable { get; set; }

        [DataProperty(0, 2)]
        public virtual Guid ID { get; set; }

        [DataProperty(1, 0)]
        public virtual string Name { get; set; }

        [DataProperty(2, 1)]
        public virtual string Description { get; set; }

        public DataModel()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
