using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class ErrorForm : Form
    {
        string Message;
        public ErrorForm(string message)
        {
            this.Message = message;
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = Message;
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
