using System;

namespace Infrastructure.Models
{
    public interface IClosableUI
    {
        public void CloseViewClick(object sender, EventArgs e);
    }
}
