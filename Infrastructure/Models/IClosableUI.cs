using System;

namespace Infrastructure.Models
{
    public interface IClosableUI
    {
        public string ConnectionString { get; set; }
        public void CloseViewClick(object sender, EventArgs e);
    }
}
