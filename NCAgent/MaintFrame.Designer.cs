namespace NCAgent
{
    partial class MaintFrame
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
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.ngAgentLogListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.connectButton.Location = new System.Drawing.Point(429, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 60);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sendButton.Location = new System.Drawing.Point(522, 12);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 60);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ngAgentLogListBox
            // 
            this.ngAgentLogListBox.FormattingEnabled = true;
            this.ngAgentLogListBox.ItemHeight = 12;
            this.ngAgentLogListBox.Location = new System.Drawing.Point(12, 82);
            this.ngAgentLogListBox.Name = "ngAgentLogListBox";
            this.ngAgentLogListBox.Size = new System.Drawing.Size(597, 268);
            this.ngAgentLogListBox.TabIndex = 2;
            // 
            // MaintFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.ngAgentLogListBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Name = "MaintFrame";
            this.Text = "NC Agent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ListBox ngAgentLogListBox;
    }
}

