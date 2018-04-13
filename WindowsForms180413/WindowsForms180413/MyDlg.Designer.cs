namespace WindowsForms180413
{
    partial class MyDlg
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
            this.bntOK = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(12, 24);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(147, 153);
            this.bntOK.TabIndex = 0;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(238, 26);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(147, 153);
            this.bntCancel.TabIndex = 1;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(464, 24);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(147, 153);
            this.bntExit.TabIndex = 2;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // MyDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 205);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntOK);
            this.Name = "MyDlg";
            this.Text = "MyDlg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Button bntExit;
    }
}