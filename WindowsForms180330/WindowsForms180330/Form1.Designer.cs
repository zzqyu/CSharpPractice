namespace WindowsForms180330
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
            this.lvwPeolpleInfo = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwPeolpleInfo
            // 
            this.lvwPeolpleInfo.Location = new System.Drawing.Point(12, 12);
            this.lvwPeolpleInfo.Name = "lvwPeolpleInfo";
            this.lvwPeolpleInfo.Size = new System.Drawing.Size(496, 188);
            this.lvwPeolpleInfo.TabIndex = 0;
            this.lvwPeolpleInfo.UseCompatibleStateImageBehavior = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 227);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name : ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(207, 227);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 12);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age : ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(350, 227);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(58, 12);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 224);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(267, 224);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(65, 21);
            this.txtAge.TabIndex = 5;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Gay",
            "레즈"});
            this.cmbGender.Location = new System.Drawing.Point(403, 224);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(105, 20);
            this.cmbGender.TabIndex = 6;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(88, 279);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(113, 33);
            this.bntAdd.TabIndex = 7;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(209, 279);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(113, 33);
            this.bntDelete.TabIndex = 8;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntEdit
            // 
            this.bntEdit.Location = new System.Drawing.Point(328, 279);
            this.bntEdit.Name = "bntEdit";
            this.bntEdit.Size = new System.Drawing.Size(113, 33);
            this.bntEdit.TabIndex = 9;
            this.bntEdit.Text = "Edit";
            this.bntEdit.UseVisualStyleBackColor = true;
            this.bntEdit.Click += new System.EventHandler(this.bntEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 324);
            this.Controls.Add(this.bntEdit);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lvwPeolpleInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPeolpleInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntEdit;
    }
}

