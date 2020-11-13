using System;

namespace DatabaseLibrary.Models
{
    public class AddditionalClientInfoModel : DataModel
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Name { get => base.Name; set => base.Name = value; }

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region overrides

        [DataProperty(0, 3)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        #endregion

        #region data props

        [DataProperty(1, 0)]
        public string Address { get; set; }

        [DataProperty(2, 1)]
        public string AdditionalContactNumber { get; set; }

        [DataProperty(3, 2)]
        public string Preferences { get; set; }

        #endregion data props

        public AddditionalClientInfoModel()
        {
            Address = string.Empty;
            AdditionalContactNumber = string.Empty;
            Preferences = string.Empty;
        }
    }
}