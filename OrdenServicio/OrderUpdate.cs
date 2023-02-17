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
    public partial class OrderUpdate : Form
    {
        public OrderUpdate()
        {
            InitializeComponent();
            cmbCondition.SelectedIndex= 0;
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        #region icon cerrar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
