namespace WindowsForms180330_2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPicture3 = new System.Windows.Forms.RadioButton();
            this.rdoPicture2 = new System.Windows.Forms.RadioButton();
            this.rdoPicture1 = new System.Windows.Forms.RadioButton();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtPictiuecmt = new System.Windows.Forms.TextBox();
            this.bntComment = new System.Windows.Forms.Button();
            this.bntDisplay = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPicture3);
            this.groupBox1.Controls.Add(this.rdoPicture2);
            this.groupBox1.Controls.Add(this.rdoPicture1);
            this.groupBox1.Controls.Add(this.chkVisible);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoPicture3
            // 
            this.rdoPicture3.AutoSize = true;
            this.rdoPicture3.Location = new System.Drawing.Point(7, 140);
            this.rdoPicture3.Name = "rdoPicture3";
            this.rdoPicture3.Size = new System.Drawing.Size(53, 16);
            this.rdoPicture3.TabIndex = 3;
            this.rdoPicture3.TabStop = true;
            this.rdoPicture3.Text = "사진3";
            this.rdoPicture3.UseVisualStyleBackColor = true;
            this.rdoPicture3.CheckedChanged += new System.EventHandler(this.rdoPicture3_CheckedChanged);
            // 
            // rdoPicture2
            // 
            this.rdoPicture2.AutoSize = true;
            this.rdoPicture2.Location = new System.Drawing.Point(7, 108);
            this.rdoPicture2.Name = "rdoPicture2";
            this.rdoPicture2.Size = new System.Drawing.Size(53, 16);
            this.rdoPicture2.TabIndex = 2;
            this.rdoPicture2.TabStop = true;
            this.rdoPicture2.Text = "사진2";
            this.rdoPicture2.UseVisualStyleBackColor = true;
            this.rdoPicture2.CheckedChanged += new System.EventHandler(this.rdoPicture2_CheckedChanged);
            // 
            // rdoPicture1
            // 
            this.rdoPicture1.AutoSize = true;
            this.rdoPicture1.Location = new System.Drawing.Point(7, 75);
            this.rdoPicture1.Name = "rdoPicture1";
            this.rdoPicture1.Size = new System.Drawing.Size(53, 16);
            this.rdoPicture1.TabIndex = 1;
            this.rdoPicture1.TabStop = true;
            this.rdoPicture1.Text = "사진1";
            this.rdoPicture1.UseVisualStyleBackColor = true;
            this.rdoPicture1.CheckedChanged += new System.EventHandler(this.rdoPicture1_CheckedChanged);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(7, 21);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(88, 16);
            this.chkVisible.TabIndex = 0;
            this.chkVisible.Text = "그림 보이기";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 369);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(58, 12);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Message";
            // 
            // txtPictiuecmt
            // 
            this.txtPictiuecmt.Location = new System.Drawing.Point(12, 396);
            this.txtPictiuecmt.Name = "txtPictiuecmt";
            this.txtPictiuecmt.Size = new System.Drawing.Size(199, 21);
            this.txtPictiuecmt.TabIndex = 3;
            // 
            // bntComment
            // 
            this.bntComment.Location = new System.Drawing.Point(72, 439);
            this.bntComment.Name = "bntComment";
            this.bntComment.Size = new System.Drawing.Size(75, 23);
            this.bntComment.TabIndex = 4;
            this.bntComment.Text = "설명";
            this.bntComment.UseVisualStyleBackColor = true;
            this.bntComment.Click += new System.EventHandler(this.bntComment_Click);
            // 
            // bntDisplay
            // 
            this.bntDisplay.Location = new System.Drawing.Point(72, 502);
            this.bntDisplay.Name = "bntDisplay";
            this.bntDisplay.Size = new System.Drawing.Size(75, 23);
            this.bntDisplay.TabIndex = 5;
            this.bntDisplay.Text = "Display";
            this.bntDisplay.UseVisualStyleBackColor = true;
            this.bntDisplay.Click += new System.EventHandler(this.bntDisplay_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(72, 564);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 6;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(72, 670);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "E&xit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.bntDisplay);
            this.Controls.Add(this.bntComment);
            this.Controls.Add(this.txtPictiuecmt);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPicture3;
        private System.Windows.Forms.RadioButton rdoPicture2;
        private System.Windows.Forms.RadioButton rdoPicture1;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtPictiuecmt;
        private System.Windows.Forms.Button bntComment;
        private System.Windows.Forms.Button bntDisplay;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button button4;
    }
}

