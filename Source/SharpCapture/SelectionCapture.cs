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

namespace SharpCapture
{
    public partial class SelectionCapture : Form
    {
        private SharpCaptureMain MainForm;

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
                    Close();
                }
                else
                {
                    MainForm.Visible = true;
                }
            }
        }
    }
}