namespace SharpCapture
{
    partial class SharpCaptureMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpCaptureMain));
            this.FunctionList = new System.Windows.Forms.MenuStrip();
            this.CaptureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FullScreenCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectionCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.DelayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NoneCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.OneSecondCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.TwoSecondCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.ThreeSecondCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.FourSecondCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.FiveSecondCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FunctionList.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionList
            // 
            this.FunctionList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FunctionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FunctionList.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.FunctionList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureMenu,
            this.DelayMenu,
            this.HelpMenu,
            this.SettingMenu});
            this.FunctionList.Location = new System.Drawing.Point(0, 0);
            this.FunctionList.Name = "FunctionList";
            this.FunctionList.Size = new System.Drawing.Size(407, 54);
            this.FunctionList.TabIndex = 0;
            this.FunctionList.Text = "FunctionList";
            // 
            // CaptureMenu
            // 
            this.CaptureMenu.AutoSize = false;
            this.CaptureMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullScreenCapture,
            this.SelectionCapture});
            this.CaptureMenu.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.CaptureMenu.Image = global::SharpCapture.Properties.Resources.Capture;
            this.CaptureMenu.Name = "CaptureMenu";
            this.CaptureMenu.Size = new System.Drawing.Size(100, 50);
            this.CaptureMenu.Text = "캡처";
            // 
            // FullScreenCapture
            // 
            this.FullScreenCapture.AutoSize = false;
            this.FullScreenCapture.Image = global::SharpCapture.Properties.Resources.FullScreen;
            this.FullScreenCapture.Name = "FullScreenCapture";
            this.FullScreenCapture.Size = new System.Drawing.Size(150, 50);
            this.FullScreenCapture.Text = "전체 캡쳐";
            this.FullScreenCapture.Click += new System.EventHandler(this.FullScreenCapture_Click);
            // 
            // SelectionCapture
            // 
            this.SelectionCapture.AutoSize = false;
            this.SelectionCapture.Image = global::SharpCapture.Properties.Resources.Selection;
            this.SelectionCapture.Name = "SelectionCapture";
            this.SelectionCapture.Size = new System.Drawing.Size(150, 50);
            this.SelectionCapture.Text = "선택 캡쳐";
            this.SelectionCapture.Click += new System.EventHandler(this.SelectionCapture_Click);
            // 
            // DelayMenu
            // 
            this.DelayMenu.AutoSize = false;
            this.DelayMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoneCheck,
            this.OneSecondCheck,
            this.TwoSecondCheck,
            this.ThreeSecondCheck,
            this.FourSecondCheck,
            this.FiveSecondCheck});
            this.DelayMenu.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.DelayMenu.Image = global::SharpCapture.Properties.Resources.Delay;
            this.DelayMenu.Name = "DelayMenu";
            this.DelayMenu.Size = new System.Drawing.Size(100, 50);
            this.DelayMenu.Text = "지연";
            // 
            // NoneCheck
            // 
            this.NoneCheck.AutoSize = false;
            this.NoneCheck.Checked = true;
            this.NoneCheck.CheckOnClick = true;
            this.NoneCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoneCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NoneCheck.Name = "NoneCheck";
            this.NoneCheck.Size = new System.Drawing.Size(150, 26);
            this.NoneCheck.Text = "없음";
            this.NoneCheck.Click += new System.EventHandler(this.NoneCheck_Click);
            // 
            // OneSecondCheck
            // 
            this.OneSecondCheck.AutoSize = false;
            this.OneSecondCheck.CheckOnClick = true;
            this.OneSecondCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OneSecondCheck.Name = "OneSecondCheck";
            this.OneSecondCheck.Size = new System.Drawing.Size(150, 26);
            this.OneSecondCheck.Text = "1초";
            this.OneSecondCheck.Click += new System.EventHandler(this.OneSecondCheck_Click);
            // 
            // TwoSecondCheck
            // 
            this.TwoSecondCheck.AutoSize = false;
            this.TwoSecondCheck.CheckOnClick = true;
            this.TwoSecondCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TwoSecondCheck.Name = "TwoSecondCheck";
            this.TwoSecondCheck.Size = new System.Drawing.Size(150, 26);
            this.TwoSecondCheck.Text = "2초";
            this.TwoSecondCheck.Click += new System.EventHandler(this.TwoSecondCheck_Click);
            // 
            // ThreeSecondCheck
            // 
            this.ThreeSecondCheck.AutoSize = false;
            this.ThreeSecondCheck.CheckOnClick = true;
            this.ThreeSecondCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ThreeSecondCheck.Name = "ThreeSecondCheck";
            this.ThreeSecondCheck.Size = new System.Drawing.Size(150, 26);
            this.ThreeSecondCheck.Text = "3초";
            this.ThreeSecondCheck.Click += new System.EventHandler(this.ThreeSecondCheck_Click);
            // 
            // FourSecondCheck
            // 
            this.FourSecondCheck.AutoSize = false;
            this.FourSecondCheck.CheckOnClick = true;
            this.FourSecondCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FourSecondCheck.Name = "FourSecondCheck";
            this.FourSecondCheck.Size = new System.Drawing.Size(150, 26);
            this.FourSecondCheck.Text = "4초";
            this.FourSecondCheck.Click += new System.EventHandler(this.FourSecondCheck_Click);
            // 
            // FiveSecondCheck
            // 
            this.FiveSecondCheck.AutoSize = false;
            this.FiveSecondCheck.CheckOnClick = true;
            this.FiveSecondCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiveSecondCheck.Name = "FiveSecondCheck";
            this.FiveSecondCheck.Size = new System.Drawing.Size(150, 26);
            this.FiveSecondCheck.Text = "5초";
            this.FiveSecondCheck.Click += new System.EventHandler(this.FiveSecondCheck_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.AutoSize = false;
            this.HelpMenu.AutoToolTip = true;
            this.HelpMenu.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.HelpMenu.Image = global::SharpCapture.Properties.Resources.Help;
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(100, 50);
            this.HelpMenu.Text = "도움말";
            this.HelpMenu.Click += new System.EventHandler(this.HelpMenu_Click);
            // 
            // SettingMenu
            // 
            this.SettingMenu.AutoSize = false;
            this.SettingMenu.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.SettingMenu.Image = global::SharpCapture.Properties.Resources.Setting;
            this.SettingMenu.Name = "SettingMenu";
            this.SettingMenu.Size = new System.Drawing.Size(100, 50);
            this.SettingMenu.Text = "옵션";
            this.SettingMenu.Click += new System.EventHandler(this.SettingMenu_Click);
            // 
            // SharpCaptureMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 53);
            this.Controls.Add(this.FunctionList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.FunctionList;
            this.MaximizeBox = false;
            this.Name = "SharpCaptureMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpCapture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SharpCaptureMain_FormClosed);
            this.Load += new System.EventHandler(this.SharpCaptureMain_Load);
            this.FunctionList.ResumeLayout(false);
            this.FunctionList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip FunctionList;
        private System.Windows.Forms.ToolStripMenuItem CaptureMenu;
        private System.Windows.Forms.ToolStripMenuItem FullScreenCapture;
        private System.Windows.Forms.ToolStripMenuItem SelectionCapture;
        private System.Windows.Forms.ToolStripMenuItem DelayMenu;
        private System.Windows.Forms.ToolStripMenuItem NoneCheck;
        private System.Windows.Forms.ToolStripMenuItem OneSecondCheck;
        private System.Windows.Forms.ToolStripMenuItem TwoSecondCheck;
        private System.Windows.Forms.ToolStripMenuItem ThreeSecondCheck;
        private System.Windows.Forms.ToolStripMenuItem FourSecondCheck;
        private System.Windows.Forms.ToolStripMenuItem FiveSecondCheck;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingMenu;
    }
}

