namespace ListsBenF
{
    partial class frmLists
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
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(90, 102);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(120, 95);
            this.lstMarks.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(113, 203);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(100, 76);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 2;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 298);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lstMarks);
            this.Name = "frmLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lists Benjamin Falsetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMarks;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtMark;
    }
}

