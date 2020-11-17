using System;

namespace DatabaseLibrary.Models
{
    public class ArchiveModel : DataModel
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Name { get => base.Name; set => base.Name = value; }

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region override

        [DataProperty(0, 2)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        #endregion

        #region data props

        [DataProperty(1, 0)]
        public ClientModel Client { get; set; }

        [DataProperty(2, 1)]
        public string Reason { get; set; }

        #endregion data props

        public ArchiveModel()
        {
            Client = new ClientModel();
            Reason = string.Empty;
        }
    }
}
