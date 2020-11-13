using System;

namespace DatabaseLibrary.Models
{
    public class ServiceModel : DataModel
    {
        #region overrides

        [DataProperty(0, 3)]
        public override Guid ID { get => base.ID; set => base.ID = value; }
        [DataProperty(1, 0)]
        public override string Name { get => base.Name; set => base.Name = value; }
        [DataProperty(2, 1)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion

        #region data props

        [DataProperty(3, 2)]
        public double Price { get; set; }

        #endregion data props
        public ServiceModel()
        {
            Price = 0;
        }
    }
}
