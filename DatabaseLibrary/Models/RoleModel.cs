namespace DatabaseLibrary.Models
{
    public class RoleModel : DataModel
    {
        public RoleModel() { }
        public RoleModel(bool IsIgnorable = false) : base() => this.IsIgnorable = IsIgnorable;
    }
}
