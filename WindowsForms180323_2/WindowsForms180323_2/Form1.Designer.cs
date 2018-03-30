namespace WindowsForms180323_2
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
            this.bntList2Checked = new System.Windows.Forms.Button();
            this.bntChecked2List = new System.Windows.Forms.Button();
            this.bntChecked2TextBox = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.cklLanguages = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // bntList2Checked
            // 
            this.bntList2Checked.Location = new System.Drawing.Point(373, 37);
            this.bntList2Checked.Name = "bntList2Checked";
            this.bntList2Checked.Size = new System.Drawing.Size(64, 50);
            this.bntList2Checked.TabIndex = 2;
            this.bntList2Checked.Text = "▶";
            this.bntList2Checked.UseVisualStyleBackColor = true;
            this.bntList2Checked.Click += new System.EventHandler(this.bntList2Checked_Click);
            // 
            // bntChecked2List
            // 
            this.bntChecked2List.Location = new System.Drawing.Point(373, 127);
            this.bntChecked2List.Name = "bntChecked2List";
            this.bntChecked2List.Size = new System.Drawing.Size(64, 50);
            this.bntChecked2List.TabIndex = 3;
            this.bntChecked2List.Text = "◀";
            this.bntChecked2List.UseVisualStyleBackColor = true;
            this.bntChecked2List.Click += new System.EventHandler(this.bntChecked2List_Click);
            // 
            // bntChecked2TextBox
            // 
            this.bntChecked2TextBox.Location = new System.Drawing.Point(611, 350);
            this.bntChecked2TextBox.Name = "bntChecked2TextBox";
            this.bntChecked2TextBox.Size = new System.Drawing.Size(102, 39);
            this.bntChecked2TextBox.TabIndex = 4;
            this.bntChecked2TextBox.Text = "◀◀";
            this.bntChecked2TextBox.UseVisualStyleBackColor = true;
            this.bntChecked2TextBox.Click += new System.EventHandler(this.bntChecked2TextBox_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(12, 268);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(475, 203);
            this.txtNote.TabIndex = 5;
            this.txtNote.WordWrap = false;
            // 
            // lstLanguages
            // 
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.ItemHeight = 12;
            this.lstLanguages.Items.AddRange(new object[] {
            "Java",
            "C",
            "C++",
            "Python",
            "C#",
            "Visual Basic .NET",
            "PHP",
            "JavaScript",
            "Ruby",
            "SQL",
            "Perl",
            "Swift",
            "Delphi/Object Pascal",
            "Objective-C",
            "Visual Basic",
            "Assembly language",
            "Go",
            "MATLAB",
            "PL/SQL",
            "R"});
            this.lstLanguages.Location = new System.Drawing.Point(12, 12);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(326, 220);
            this.lstLanguages.TabIndex = 6;
            // 
            // cklLanguages
            // 
            this.cklLanguages.CheckOnClick = true;
            this.cklLanguages.FormattingEnabled = true;
            this.cklLanguages.Location = new System.Drawing.Point(488, 12);
            this.cklLanguages.Name = "cklLanguages";
            this.cklLanguages.Size = new System.Drawing.Size(338, 212);
            this.cklLanguages.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 483);
            this.Controls.Add(this.cklLanguages);
            this.Controls.Add(this.lstLanguages);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.bntChecked2TextBox);
            this.Controls.Add(this.bntChecked2List);
            this.Controls.Add(this.bntList2Checked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntList2Checked;
        private System.Windows.Forms.Button bntChecked2List;
        private System.Windows.Forms.Button bntChecked2TextBox;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.CheckedListBox cklLanguages;
    }
}

