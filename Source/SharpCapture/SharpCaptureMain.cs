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
    public partial class SharpCaptureMain : Form
    {
        private bool NoneCheckFlag = true;
        private bool OneSecondCheckFlag = false;
        private bool TwoSecondCheckFlag = false;
        private bool ThreeSecondCheckFlag = false;
        private bool FourSecondCheckFlag = false;
        private bool FiveSecondCheckFlag = false;

        public bool CopyClipBoard;
        public bool CheckSave;
        public bool ScreenOverlay;

        private int CaptureDelay = 0;
        public Point SelectionCapturePos;
        public Size CaptureSize;

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public SharpCaptureMain()
        {
            InitializeComponent();
        }

        private void SharpCaptureMain_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            CopyClipBoard = Properties.Settings.Default.ClipBoardSetting;
            CheckSave = Properties.Settings.Default.CheckSaveSetting;
            ScreenOverlay = Properties.Settings.Default.ScreenOverlaySetting;
        }

        private void FullScreenCapture_Click(object sender, EventArgs e)
        {
            Visible = false;
            Thread.Sleep(200);
            Thread.Sleep(CaptureDelay);
            CaptureSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Bitmap ScreenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics ScreenGraphics = Graphics.FromImage(ScreenBitmap);
            ScreenGraphics.CopyFromScreen(0, 0, 0, 0, CaptureSize);
            Image ScreenImage = ScreenBitmap as Image;
            if (CopyClipBoard)
            {
                Clipboard.SetImage(ScreenImage);
            }
            Visible = true;
            ShowFullScreenCapture ShowFullScreenCaptureForm = new ShowFullScreenCapture(ScreenImage, CheckSave);
            ShowFullScreenCaptureForm.ShowDialog();
        }

        private void SelectionCapture_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            Thread.Sleep(CaptureDelay);
            SelectionCapture SelectionCaptureForm = new SelectionCapture(ScreenOverlay);
            SelectionCaptureForm.Owner = this;
            if(SelectionCaptureForm.ShowDialog() == DialogResult.OK)
            {
                Bitmap ScreenBitmap = new Bitmap(CaptureSize.Width, CaptureSize.Height);
                Graphics ScreenGraphics = Graphics.FromImage(ScreenBitmap);
                ScreenGraphics.CopyFromScreen(SelectionCapturePos.X, SelectionCapturePos.Y, 0, 0, CaptureSize);
                Image ScreenImage = ScreenBitmap as Image;
                if (CopyClipBoard)
                {
                    Clipboard.SetImage(ScreenImage);
                }
                Visible = true;
                ShowFullScreenCapture ShowFullScreenCaptureForm = new ShowFullScreenCapture(ScreenImage, CheckSave);
                ShowFullScreenCaptureForm.ShowDialog();
            }
            
        }

        private void NoneCheck_Click(object sender, EventArgs e)
        {
            if(NoneCheckFlag)
            {
                NoneCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 0;

                NoneCheck.Checked = true;
                OneSecondCheck.Checked = false;
                TwoSecondCheck.Checked = false;
                ThreeSecondCheck.Checked = false;
                FourSecondCheck.Checked = false;
                FiveSecondCheck.Checked = false;

                NoneCheckFlag = true;
                OneSecondCheckFlag = false;
                TwoSecondCheckFlag = false;
                ThreeSecondCheckFlag = false;
                FourSecondCheckFlag = false;
                FiveSecondCheckFlag = false;
            }
        }

        private void OneSecondCheck_Click(object sender, EventArgs e)
        {
            if (OneSecondCheckFlag)
            {
                OneSecondCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 1000;

                NoneCheck.Checked = false;
                OneSecondCheck.Checked = true;
                TwoSecondCheck.Checked = false;
                ThreeSecondCheck.Checked = false;
                FourSecondCheck.Checked = false;
                FiveSecondCheck.Checked = false;
                
                NoneCheckFlag = false;
                OneSecondCheckFlag = true;
                TwoSecondCheckFlag = false;
                ThreeSecondCheckFlag = false;
                FourSecondCheckFlag = false;
                FiveSecondCheckFlag = false;
            }
        }

        private void TwoSecondCheck_Click(object sender, EventArgs e)
        {
            if (TwoSecondCheckFlag)
            {
                TwoSecondCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 2000;

                NoneCheck.Checked = false;
                OneSecondCheck.Checked = false;
                TwoSecondCheck.Checked = true;
                ThreeSecondCheck.Checked = false;
                FourSecondCheck.Checked = false;
                FiveSecondCheck.Checked = false;

                NoneCheckFlag = false;
                OneSecondCheckFlag = false;
                TwoSecondCheckFlag = true;
                ThreeSecondCheckFlag = false;
                FourSecondCheckFlag = false;
                FiveSecondCheckFlag = false;
            }
        }

        private void ThreeSecondCheck_Click(object sender, EventArgs e)
        {
            if (ThreeSecondCheckFlag)
            {
                ThreeSecondCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 3000;

                NoneCheck.Checked = false;
                OneSecondCheck.Checked = false;
                TwoSecondCheck.Checked = false;
                ThreeSecondCheck.Checked = true;
                FourSecondCheck.Checked = false;
                FiveSecondCheck.Checked = false;

                NoneCheckFlag = false;
                OneSecondCheckFlag = false;
                TwoSecondCheckFlag = false;
                ThreeSecondCheckFlag = true;
                FourSecondCheckFlag = false;
                FiveSecondCheckFlag = false;
            }
        }

        private void FourSecondCheck_Click(object sender, EventArgs e)
        {
            if (FourSecondCheckFlag)
            {
                FourSecondCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 4000;

                NoneCheck.Checked = false;
                OneSecondCheck.Checked = false;
                TwoSecondCheck.Checked = false;
                ThreeSecondCheck.Checked = false;
                FourSecondCheck.Checked = true;
                FiveSecondCheck.Checked = false;

                NoneCheckFlag = false;
                OneSecondCheckFlag = false;
                TwoSecondCheckFlag = false;
                ThreeSecondCheckFlag = false;
                FourSecondCheckFlag = true;
                FiveSecondCheckFlag = false;
            }
        }

        private void FiveSecondCheck_Click(object sender, EventArgs e)
        {
            if (FiveSecondCheckFlag)
            {
                FiveSecondCheck.Checked = true;
            }
            else
            {
                CaptureDelay = 5000;

                NoneCheck.Checked = false;
                OneSecondCheck.Checked = false;
                TwoSecondCheck.Checked = false;
                ThreeSecondCheck.Checked = false;
                FourSecondCheck.Checked = false;
                FiveSecondCheck.Checked = true;

                NoneCheckFlag = false;
                OneSecondCheckFlag = false;
                TwoSecondCheckFlag = false;
                ThreeSecondCheckFlag = false;
                FourSecondCheckFlag = false;
                FiveSecondCheckFlag = true;
            }
        }

        private void SettingMenu_Click(object sender, EventArgs e)
        {
            SharpCaptureSetting SettingForm = new SharpCaptureSetting(CopyClipBoard, CheckSave, ScreenOverlay);
            SettingForm.Owner = this;
            SettingForm.ShowDialog();
        }

        private void HelpMenu_Click(object sender, EventArgs e)
        {
            SelectionCaptureHelp HelpForm = new SelectionCaptureHelp();
            HelpForm.ShowDialog();
        }

        private void SharpCaptureMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.ClipBoardSetting = CopyClipBoard;
            Properties.Settings.Default.CheckSaveSetting = CheckSave;
            Properties.Settings.Default.ScreenOverlaySetting = ScreenOverlay;
            Properties.Settings.Default.Save();
        }
    }
}