namespace NumericFileRenamer
{
    partial class Form1
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
            this.btnRename = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.numName = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(195, 26);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(76, 20);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectory.Location = new System.Drawing.Point(9, 8);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(31, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Dir:";
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(138, 26);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(51, 20);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.Text = "Dir";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // numName
            // 
            this.numName.Location = new System.Drawing.Point(12, 26);
            this.numName.Name = "numName";
            this.numName.Size = new System.Drawing.Size(120, 20);
            this.numName.TabIndex = 4;
            this.numName.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 58);
            this.Controls.Add(this.numName);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.btnRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Numeric File Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.numName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.NumericUpDown numName;
    }
}

