using System;
using System.Windows.Forms;

namespace Infrastructure
{
    public partial class InputBox : Form
    {
        internal string InputValue { get; set; }
        public InputBox() => InitializeComponent();
        private void Button1_Click(object sender, EventArgs e)
        {
            InputValue = textBox1.Text;
            Close();
        }
    }
}
