namespace FileChecker
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPath1 = new System.Windows.Forms.Label();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.btnBrowsePath1 = new System.Windows.Forms.Button();
            this.btnBrowsePath2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.lblPath2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblPath1
            // 
            this.lblPath1.AutoSize = true;
            this.lblPath1.Location = new System.Drawing.Point(12, 40);
            this.lblPath1.Name = "lblPath1";
            this.lblPath1.Size = new System.Drawing.Size(38, 13);
            this.lblPath1.TabIndex = 0;
            this.lblPath1.Text = "Path1:";
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(69, 40);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(266, 20);
            this.txtPath1.TabIndex = 1;
            this.txtPath1.TextChanged += new System.EventHandler(this.txtPath1_TextChanged);
            // 
            // btnBrowsePath1
            // 
            this.btnBrowsePath1.Location = new System.Drawing.Point(355, 40);
            this.btnBrowsePath1.Name = "btnBrowsePath1";
            this.btnBrowsePath1.Size = new System.Drawing.Size(77, 20);
            this.btnBrowsePath1.TabIndex = 2;
            this.btnBrowsePath1.Text = "Browse";
            this.btnBrowsePath1.UseVisualStyleBackColor = true;
            this.btnBrowsePath1.Click += new System.EventHandler(this.btnBrowsePath1_Click);
            // 
            // btnBrowsePath2
            // 
            this.btnBrowsePath2.Location = new System.Drawing.Point(355, 89);
            this.btnBrowsePath2.Name = "btnBrowsePath2";
            this.btnBrowsePath2.Size = new System.Drawing.Size(77, 20);
            this.btnBrowsePath2.TabIndex = 2;
            this.btnBrowsePath2.Text = "Browse";
            this.btnBrowsePath2.UseVisualStyleBackColor = true;
            this.btnBrowsePath2.Click += new System.EventHandler(this.btnBrowsePath2_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(69, 89);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(266, 20);
            this.txtPath2.TabIndex = 1;
            this.txtPath2.TextChanged += new System.EventHandler(this.txtPath2_TextChanged);
            // 
            // lblPath2
            // 
            this.lblPath2.AutoSize = true;
            this.lblPath2.Location = new System.Drawing.Point(12, 92);
            this.lblPath2.Name = "lblPath2";
            this.lblPath2.Size = new System.Drawing.Size(38, 13);
            this.lblPath2.TabIndex = 0;
            this.lblPath2.Text = "Path2:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 169);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(355, 166);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(77, 20);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(69, 166);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(266, 20);
            this.txtOutputPath.TabIndex = 1;
            this.txtOutputPath.TextChanged += new System.EventHandler(this.txtOutputPath_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(355, 221);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listOptions
            // 
            this.listOptions.FormattingEnabled = true;
            this.listOptions.Location = new System.Drawing.Point(195, 192);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(120, 56);
            this.listOptions.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.listOptions);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.btnBrowsePath2);
            this.Controls.Add(this.btnBrowsePath1);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.lblPath2);
            this.Controls.Add(this.lblPath1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button btnBrowsePath1;
        private System.Windows.Forms.Button btnBrowsePath2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Label lblPath2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listOptions;
    }
}

