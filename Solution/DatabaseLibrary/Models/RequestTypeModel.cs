using System;
using System.ComponentModel;

namespace DatabaseLibrary.Models
{
    public class RequestTypeModel : DataModel
    {
        #region override

        [DataProperty(0, 4)]
        public override Guid ID { get => base.ID; set => base.ID = value; }

        [DataProperty(1, 0)]
        [ItemType("TextBox")]
        [Description("Название")]
        public override string Name { get => base.Name; set => base.Name = value; }

        [DataProperty(2, 1)]
        [ItemType("TextBox")]
        [Description("Описание")]
        public override string Description { get => base.Description; set => base.Description = value; }

        #endregion override

        #region data props

        [DataProperty(3, 2)]
        [ItemType("TextBox")]
        [Description("Сокращение")]
        public string ShortName { get; set; }

        [DataProperty(4, 3)]
        [ItemType("CheckBox")]
        [Description("Требует работы других сотрудников")]
        public bool RequireOtherWorks { get; set; }

        #endregion data props

        public RequestTypeModel()
        {
            ShortName = string.Empty;
            RequireOtherWorks = true;
        }

    }
}
