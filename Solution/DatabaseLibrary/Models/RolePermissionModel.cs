using System;
using System.ComponentModel;

namespace DatabaseLibrary.Models
{
    public class RolePermissionModel : DataModel
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Name { get => base.Name; set => base.Name = value; }

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region overrides

        [DataProperty(0, 2)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        #endregion
        #region data props

        [DataProperty(1, 0)]
        [Description("Код роли")]
        public Guid RoleGuid { get; set; }

        [DataProperty(2, 1)]
        [Description("Код разрешения")]
        public Guid PermissionGuid { get; set; }

        #endregion data props
    }
}
