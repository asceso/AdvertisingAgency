namespace DatabaseLibrary.Models
{
    public class PermissionModel : DataModel
    {
        public PermissionModel() { }
        public PermissionModel(bool IsIgnorable = false) : base() => this.IsIgnorable = IsIgnorable;
    }
}
