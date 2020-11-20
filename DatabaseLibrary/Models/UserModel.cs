﻿using System;
using System.ComponentModel;

namespace DatabaseLibrary.Models
{
    public class UserModel : DataModel
    {
        #region not used

        [Obsolete(NotUsedProperty, true)]
        public override string Name { get => base.Name; set => base.Name = value; }

        [Obsolete(NotUsedProperty, true)]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion not used

        #region overrides

        [DataProperty(0, 8)]
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
        [Description("Должность")]
        public PositionModel Position { get; set; }

        [DataProperty(5, 4)]
        [Description("Контактный номер")]
        public string ContactNumber { get; set; }

        [DataProperty(6, 5)]
        [Description("Логин")]
        public string Login { get; set; }

        [DataProperty(7, 6)]
        [Description("Пароль")]
        public string Password { get; set; }

        [DataProperty(7, 6)]
        [Description("Роль")]
        public RoleModel Role { get; set; }

        #endregion data props

        #region other

        [OtherProperty("Свойство возвращает ФИО сотрудника")]
        public string GetFullName { get => $"{FirstName} {MiddleName} {LastName}"; }

        public bool IsInRole(string RoleName) => Role.Name.Equals(RoleName);

        #endregion other

        public UserModel()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
            Login = "NewLogin";
            Password = "password";
        }
    }
}
