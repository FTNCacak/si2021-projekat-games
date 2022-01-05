using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void LabelMinimize_MouseHover(object sender, EventArgs e)
        {
            LabelMinimize.ForeColor = Color.White;
        }

        private void LabelClose_MouseHover(object sender, EventArgs e)
        {
            LabelClose.ForeColor = Color.White;
        }

        private void LabelMinimize_MouseLeave(object sender, EventArgs e)
        {
            LabelMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            LabelClose.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void LabelMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
