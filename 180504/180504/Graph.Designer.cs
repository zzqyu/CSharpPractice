namespace _180504
{
    partial class Graph
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
            this.책 = new System.Windows.Forms.TextBox();
            this.잡지 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.음식 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntDisplay = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 책
            // 
            this.책.Location = new System.Drawing.Point(190, 33);
            this.책.Name = "책";
            this.책.Size = new System.Drawing.Size(100, 21);
            this.책.TabIndex = 1;
            // 
            // 잡지
            // 
            this.잡지.Location = new System.Drawing.Point(190, 75);
            this.잡지.Name = "잡지";
            this.잡지.Size = new System.Drawing.Size(100, 21);
            this.잡지.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PeriodiCals";
            // 
            // 음식
            // 
            this.음식.Location = new System.Drawing.Point(190, 116);
            this.음식.Name = "음식";
            this.음식.Size = new System.Drawing.Size(100, 21);
            this.음식.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Foods";
            // 
            // bntDisplay
            // 
            this.bntDisplay.Location = new System.Drawing.Point(43, 195);
            this.bntDisplay.Name = "bntDisplay";
            this.bntDisplay.Size = new System.Drawing.Size(75, 23);
            this.bntDisplay.TabIndex = 6;
            this.bntDisplay.Text = "Display";
            this.bntDisplay.UseVisualStyleBackColor = true;
            this.bntDisplay.Click += new System.EventHandler(this.bntDisplay_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(43, 244);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 7;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(43, 295);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 23);
            this.bntExit.TabIndex = 8;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Books:Blue, Periodicals : Yello, Foods: red";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.bntDisplay);
            this.Controls.Add(this.음식);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.잡지);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.책);
            this.Controls.Add(this.label1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox 책;
        private System.Windows.Forms.TextBox 잡지;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 음식;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntDisplay;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}