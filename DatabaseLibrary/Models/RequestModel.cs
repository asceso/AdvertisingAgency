using System;
using System.ComponentModel;

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
        [Description("Название")]
        public override string Name { get => base.Name; set => base.Name = value; }

        #endregion

        #region data props

        [DataProperty(2, 1)]
        [Description("Номер заявки")]
        public string Number { get; set; }

        [DataProperty(3, 2)]
        [Description("Тип заявки")]
        public RequestTypeModel RequestType { get; set; }

        [DataProperty(4, 3)]
        [Description("Адрес")]
        public string Address { get; set; }

        [DataProperty(5, 4)]
        [Description("Услуга")]
        public ServiceModel Service { get; set; }

        [DataProperty(6, 5)]
        [Description("Сотрудник")]
        public UserModel User { get; set; }

        [DataProperty(7, 6)]
        [Description("Клиент")]
        public ClientModel Client { get; set; }

        [DataProperty(8, 7)]
        [Description("Статус заявки")]
        public int Status { get; set; }

        #endregion data props

        public RequestModel()
        {
            Number = "0000000000";
            Address = string.Empty;
            Status = 0;
            RequestType = new RequestTypeModel();
            Service = new ServiceModel();
            User = new UserModel();
            Client = new ClientModel();
        }
    }
}
