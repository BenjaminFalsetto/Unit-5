namespace FileReadWriteBenF
{
    partial class frmFileReadWrite
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
            this.lblCompare = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(57, 47);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(214, 26);
            this.lblCompare.TabIndex = 0;
            this.lblCompare.Text = "Compare strings on each line of input .txt file\r\n(Case doesn\'t matter)";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(127, 139);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmFileReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 291);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblCompare);
            this.Name = "frmFileReadWrite";
            this.Text = "File Read Write Benjamin Falsetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Button btnCheck;
    }
}

