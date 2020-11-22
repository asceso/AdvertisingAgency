using System;
using System.ComponentModel;

namespace DatabaseLibrary.Models
{
    public class ClientModel : DataModel, ICloneable
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Name { get => base.Name; set => base.Name = value; }

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region overrides

        [DataProperty(0, 6)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        #endregion

        #region data props

        [DataProperty(1, 0)]
        [Description("Имя")]
        public string FirstName { get; set; }

        [DataProperty(2, 1)]
        [Description("Фамилия")]
        public string MiddleName { get; set; }

        [DataProperty(3, 2)]
        [Description("Отчество")]
        public string LastName { get; set; }

        [DataProperty(4, 3)]
        [Description("Контактный номер")]
        public string ContactNumber { get; set; }

        [DataProperty(5, 4)]
        [Description("Всего заказов")]
        public int OrdersCount { get; set; }

        [DataProperty(6, 5)]
        [Description("Доп инфо")]
        public AddditionalClientInfoModel AddtionalInfo { get; set; }

        #endregion data props

        #region other

        [OtherProperty("Свойство возвращает ФИО клиента")]
        public string GetFullName => $"{FirstName} {MiddleName} {LastName}";

        #endregion other

        public ClientModel()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
            OrdersCount = 0;
        }

        public object Clone() => MemberwiseClone();
    }
}
