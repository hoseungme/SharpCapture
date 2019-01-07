namespace SharpCapture
{
    partial class SharpCaptureSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpCaptureSetting));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.ClipBoardSettingCheck = new System.Windows.Forms.CheckBox();
            this.AutoSaveSettingCheck = new System.Windows.Forms.CheckBox();
            this.ScreenOverlaySettingCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(180, 99);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 36);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(84, 99);
            this.CheckBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(90, 36);
            this.CheckBtn.TabIndex = 2;
            this.CheckBtn.Text = "확인";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ClipBoardSettingCheck
            // 
            this.ClipBoardSettingCheck.AutoSize = true;
            this.ClipBoardSettingCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClipBoardSettingCheck.Location = new System.Drawing.Point(14, 13);
            this.ClipBoardSettingCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClipBoardSettingCheck.Name = "ClipBoardSettingCheck";
            this.ClipBoardSettingCheck.Size = new System.Drawing.Size(227, 28);
            this.ClipBoardSettingCheck.TabIndex = 3;
            this.ClipBoardSettingCheck.Text = "캡처 내용을 클립보드에 복사";
            this.ClipBoardSettingCheck.UseVisualStyleBackColor = true;
            // 
            // AutoSaveSettingCheck
            // 
            this.AutoSaveSettingCheck.AutoSize = true;
            this.AutoSaveSettingCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AutoSaveSettingCheck.Location = new System.Drawing.Point(14, 38);
            this.AutoSaveSettingCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoSaveSettingCheck.Name = "AutoSaveSettingCheck";
            this.AutoSaveSettingCheck.Size = new System.Drawing.Size(272, 28);
            this.AutoSaveSettingCheck.TabIndex = 4;
            this.AutoSaveSettingCheck.Text = "끝내기 전 캡처 내용 저장 여부 확인";
            this.AutoSaveSettingCheck.UseVisualStyleBackColor = true;
            // 
            // ScreenOverlaySettingCheck
            // 
            this.ScreenOverlaySettingCheck.AutoSize = true;
            this.ScreenOverlaySettingCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ScreenOverlaySettingCheck.Location = new System.Drawing.Point(14, 63);
            this.ScreenOverlaySettingCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScreenOverlaySettingCheck.Name = "ScreenOverlaySettingCheck";
            this.ScreenOverlaySettingCheck.Size = new System.Drawing.Size(162, 28);
            this.ScreenOverlaySettingCheck.TabIndex = 5;
            this.ScreenOverlaySettingCheck.Text = "화면 오버레이 표시";
            this.ScreenOverlaySettingCheck.UseVisualStyleBackColor = true;
            // 
            // SharpCaptureSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(282, 138);
            this.Controls.Add(this.ScreenOverlaySettingCheck);
            this.Controls.Add(this.AutoSaveSettingCheck);
            this.Controls.Add(this.ClipBoardSettingCheck);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.CancelBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpCaptureSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "옵션";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.CheckBox ClipBoardSettingCheck;
        private System.Windows.Forms.CheckBox AutoSaveSettingCheck;
        private System.Windows.Forms.CheckBox ScreenOverlaySettingCheck;
    }
}