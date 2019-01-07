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
    public partial class ShowFullScreenCapture : Form
    {
        private Image CaptureScreen;
        private bool CheckSave;
        private bool SaveFlag;

        public ShowFullScreenCapture(Image CaptureScreen, bool CheckSave)
        {
            InitializeComponent();
            this.CaptureScreen = CaptureScreen;
            this.CheckSave = CheckSave;
        }

        private void ShowFullScreenCapture_Load(object sender, EventArgs e)
        {
            ShowCaptureScreenBox.Image = CaptureScreen;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DialogResult result = ImageSaveDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                ShowCaptureScreenBox.Image.Save(ImageSaveDialog.FileName);
            }
            SaveFlag = true;
            Close();
        }

        private void ShowFullScreenCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckSave && !SaveFlag)
            {
                DialogResult MessageBoxResult =  MessageBox.Show(this, "종료하기 전 저장하시겠습니까?", "SharpMemo", MessageBoxButtons.YesNoCancel);
                switch(MessageBoxResult)
                {
                    case DialogResult.Yes:
                        DialogResult result = ImageSaveDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            ShowCaptureScreenBox.Image.Save(ImageSaveDialog.FileName);
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}