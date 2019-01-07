namespace SharpCapture
{
    partial class ShowFullScreenCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveAndDeleteMenu = new System.Windows.Forms.MenuStrip();
            this.ImageSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ShowCaptureScreenBox = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAndDeleteMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptureScreenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveAndDeleteMenu
            // 
            this.SaveAndDeleteMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.SaveAndDeleteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save});
            this.SaveAndDeleteMenu.Location = new System.Drawing.Point(0, 0);
            this.SaveAndDeleteMenu.Name = "SaveAndDeleteMenu";
            this.SaveAndDeleteMenu.Size = new System.Drawing.Size(582, 54);
            this.SaveAndDeleteMenu.TabIndex = 1;
            this.SaveAndDeleteMenu.Text = "menuStrip1";
            // 
            // ImageSaveDialog
            // 
            this.ImageSaveDialog.DefaultExt = "png";
            this.ImageSaveDialog.Filter = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg, *.jpe, *.jfif)|*.jpg";
            // 
            // ShowCaptureScreenBox
            // 
            this.ShowCaptureScreenBox.Location = new System.Drawing.Point(12, 67);
            this.ShowCaptureScreenBox.Name = "ShowCaptureScreenBox";
            this.ShowCaptureScreenBox.Size = new System.Drawing.Size(0, 0);
            this.ShowCaptureScreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowCaptureScreenBox.TabIndex = 0;
            this.ShowCaptureScreenBox.TabStop = false;
            // 
            // Save
            // 
            this.Save.AutoSize = false;
            this.Save.Image = global::SharpCapture.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 50);
            this.Save.Text = "저장";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ShowFullScreenCapture
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.ShowCaptureScreenBox);
            this.Controls.Add(this.SaveAndDeleteMenu);
            this.MainMenuStrip = this.SaveAndDeleteMenu;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ShowFullScreenCapture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "캡처 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowFullScreenCapture_FormClosing);
            this.Load += new System.EventHandler(this.ShowFullScreenCapture_Load);
            this.SaveAndDeleteMenu.ResumeLayout(false);
            this.SaveAndDeleteMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptureScreenBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShowCaptureScreenBox;
        private System.Windows.Forms.MenuStrip SaveAndDeleteMenu;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.SaveFileDialog ImageSaveDialog;
    }
}