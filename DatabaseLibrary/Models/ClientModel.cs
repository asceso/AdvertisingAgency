﻿using System;

namespace DatabaseLibrary.Models
{
    public class ClientModel : DataModel
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
        public string FirstName { get; set; }

        [DataProperty(2, 1)]
        public string MiddleName { get; set; }

        [DataProperty(3, 2)]
        public string LastName { get; set; }

        [DataProperty(4, 3)]
        public string ContactNumber { get; set; }

        [DataProperty(5, 4)]
        public int OrdersCount { get; set; }

        [DataProperty(6, 5)]
        public AddditionalClientInfoModel AddtionalInfo { get; set; }

        #endregion data props

        #region other

        [OtherProperty("Свойство возвращает ФИО клиента")]
        public string GetFullName { get => $"{FirstName} {MiddleName} {LastName}"; }

        #endregion other

        public ClientModel()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
            OrdersCount = 0;
        }
    }
}