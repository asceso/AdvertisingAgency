using System;

namespace DatabaseLibrary.Models
{
    public class RequestModel : DataModel
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region override

        [DataProperty(0, 8)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        [DataProperty(1, 0)]
        public override string Name { get => base.Name; set => base.Name = value; }

        #endregion

        #region data props

        [DataProperty(2, 1)]
        public string Number { get; set; }

        [DataProperty(3, 2)]
        public RequestTypeModel RequestType { get; set; }

        [DataProperty(4, 3)]
        public string Address { get; set; }

        [DataProperty(5, 4)]
        public ServiceModel Service { get; set; }

        [DataProperty(6, 5)]
        public UserModel User { get; set; }

        [DataProperty(7, 6)]
        public ClientModel Client { get; set; }

        [DataProperty(8, 7)]
        public bool Status { get; set; }

        #endregion data props

        public RequestModel()
        {
            Number = "0000000000";
            Address = string.Empty;
            Status = false;
            RequestType = new RequestTypeModel();
            Service = new ServiceModel();
            User = new UserModel();
            Client = new ClientModel();
        }
    }
}
