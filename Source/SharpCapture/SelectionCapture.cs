using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace SharpCapture
{
    public partial class SelectionCapture : Form
    {
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        private bool CancelFlag = false;
        private bool CaptureFlag = false;

        private SharpCaptureMain MainForm;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x312)
            {
                if (m.WParam == (IntPtr)0x0)
                {
                    CancelFlag = true;
                    Close();
                }
            }
        }

        public SelectionCapture(bool ScreenOverlayFlag)
        {
            InitializeComponent();
            if (ScreenOverlayFlag)
            {
                Opacity = 50 * 0.01;
            }
            else
            {
                Opacity = 1 * 0.01;
            }
        }

        private void SelectionCapture_Load(object sender, EventArgs e)
        {
            MainForm = (SharpCaptureMain)Owner;
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.Escape);
        }

        private void SelectionCapture_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm.Visible = false;
            if(e.Button == MouseButtons.Left)
            {
                Point SelectionFormLocation = new Point(MousePosition.X, MousePosition.Y);
                Selection SelectionForm = new Selection(SelectionFormLocation);
                SelectionForm.Owner = Owner;
                if(SelectionForm.ShowDialog() == DialogResult.OK)
                {
                    CaptureFlag = true;
                    Close();
                }
                else
                {
                    MainForm.Visible = true;
                }
            }
        }

        private void SelectionCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!CancelFlag && CaptureFlag)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}