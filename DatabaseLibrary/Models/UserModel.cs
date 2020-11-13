using System;

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

        [DataProperty(0, 5)]
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
        public PositionModel Position { get; set; }

        [DataProperty(5, 4)]
        public string ContactNumber { get; set; }

        #endregion data props

        #region other

        [OtherProperty("Свойство возвращает ФИО сотрудника")]
        public string GetFullName { get => $"{FirstName} {MiddleName} {LastName}"; }

        #endregion other

        public UserModel()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            ContactNumber = string.Empty;
        }
    }
}
