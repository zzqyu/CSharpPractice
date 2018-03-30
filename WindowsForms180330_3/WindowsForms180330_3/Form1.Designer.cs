namespace WindowsForms180330_3
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
            this.lbCompany = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.bntNext = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Location = new System.Drawing.Point(45, 29);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(41, 12);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "상호명";
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Location = new System.Drawing.Point(45, 75);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(53, 12);
            this.lblPNumber.TabIndex = 1;
            this.lblPNumber.Text = "전화번호";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(125, 26);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(325, 21);
            this.txtCompany.TabIndex = 2;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(125, 72);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(325, 21);
            this.txtPNumber.TabIndex = 3;
            // 
            // bntNext
            // 
            this.bntNext.Location = new System.Drawing.Point(32, 145);
            this.bntNext.Name = "bntNext";
            this.bntNext.Size = new System.Drawing.Size(75, 23);
            this.bntNext.TabIndex = 4;
            this.bntNext.Text = "Next";
            this.bntNext.UseVisualStyleBackColor = true;
            this.bntNext.Click += new System.EventHandler(this.bntNext_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(240, 145);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 5;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(439, 145);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 6;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 180);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.bntNext);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblPNumber);
            this.Controls.Add(this.lbCompany);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.Button bntNext;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntExit;
    }
}

