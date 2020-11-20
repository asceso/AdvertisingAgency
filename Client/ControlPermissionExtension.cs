using System.Drawing;
using System.Windows.Forms;

namespace Client
{
    public static class ControlPermissionExtension
    {
        public static void SetEnabledByPermission(this Button button, bool permissionResult)
            => button.Enabled = permissionResult;
        public static void SetEnabledByPermission(this Button button, bool permissionResult, Color backColor)
        {
            SetEnabledByPermission(button, permissionResult);
            button.BackColor = backColor;
        }

        public static void SetVisibleByPermission(this Button button, bool permissionResult)
            => button.Visible = permissionResult;
        public static void UseContextMenuStripByPermission(this ListBox list, bool permissionResult, ContextMenuStrip target)
            => list.ContextMenuStrip = permissionResult ? target : null;
    }
}
