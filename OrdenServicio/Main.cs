using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenServicio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Mover PanelTop

        //Permite mover Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
               
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        #region Icon Max,Min,Rest
        private void IconClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void IconMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void IconMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
