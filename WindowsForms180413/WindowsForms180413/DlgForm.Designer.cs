namespace WindowsForms180413
{
    partial class DlgForm
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
            this.bntModal = new System.Windows.Forms.Button();
            this.bntModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntModal
            // 
            this.bntModal.Location = new System.Drawing.Point(12, 57);
            this.bntModal.Name = "bntModal";
            this.bntModal.Size = new System.Drawing.Size(241, 141);
            this.bntModal.TabIndex = 0;
            this.bntModal.Text = "Modal";
            this.bntModal.UseVisualStyleBackColor = true;
            this.bntModal.Click += new System.EventHandler(this.bntModal_Click);
            // 
            // bntModaless
            // 
            this.bntModaless.Location = new System.Drawing.Point(290, 57);
            this.bntModaless.Name = "bntModaless";
            this.bntModaless.Size = new System.Drawing.Size(241, 141);
            this.bntModaless.TabIndex = 1;
            this.bntModaless.Text = "Modaless";
            this.bntModaless.UseVisualStyleBackColor = true;
            this.bntModaless.Click += new System.EventHandler(this.bntModaless_Click);
            // 
            // DlgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.bntModaless);
            this.Controls.Add(this.bntModal);
            this.Name = "DlgForm";
            this.Text = "DlgForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntModal;
        private System.Windows.Forms.Button bntModaless;
    }
}