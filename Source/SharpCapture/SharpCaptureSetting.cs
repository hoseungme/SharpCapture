using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpCapture
{
    public partial class SharpCaptureSetting : Form
    {

        public SharpCaptureSetting(bool FirstCheckBoxFlag, bool SecondCheckBoxFlag, bool ThirdCheckBoxFlag)
        {
            InitializeComponent();
            ClipBoardSettingCheck.Checked = FirstCheckBoxFlag;
            AutoSaveSettingCheck.Checked = SecondCheckBoxFlag;
            ScreenOverlaySettingCheck.Checked = ThirdCheckBoxFlag;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SharpCaptureMain CheckBoxValueSender = (SharpCaptureMain)Owner;
            CheckBoxValueSender.CopyClipBoard = ClipBoardSettingCheck.Checked;
            CheckBoxValueSender.CheckSave = AutoSaveSettingCheck.Checked;
            CheckBoxValueSender.ScreenOverlay = ScreenOverlaySettingCheck.Checked;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
