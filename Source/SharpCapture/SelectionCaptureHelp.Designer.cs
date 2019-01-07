namespace SharpCapture
{
    partial class SelectionCaptureHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionCaptureHelp));
            this.Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.Help.Location = new System.Drawing.Point(12, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(512, 225);
            this.Help.TabIndex = 1;
            this.Help.Text = "1. 캡처\r\n - 전체캡처와 선택캡처로 나뉩니다. 전체캡처는 누르면 \r\n화면 전체를 캡처해서 띄워줍니다. 선택 캡처는 누른 후 \r\n화면을 드래그하" +
    "여 캡처할 영역을 선택하면 됩니다.\r\n2. 지연\r\n - 지연을 설정하면 캡처를 시작하기 전 설정한 시간 만큼 \r\n대기합니다. 예를 들어 지연을 " +
    "5초로 설정하고 캡처를 누르\r\n면 5초 뒤에 캡처합니다.\r\n\r\n";
            // 
            // SelectionCaptureHelp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(536, 243);
            this.Controls.Add(this.Help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionCaptureHelp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "도움말";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Help;
    }
}