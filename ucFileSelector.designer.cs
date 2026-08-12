namespace TVShowSeasonFileStructureSetup

{
    partial class ucFileSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFileExplorer = new System.Windows.Forms.Button();
            this.txtFullFileName = new System.Windows.Forms.TextBox();
            this.ofdFileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpenFileExplorer
            // 
            this.btnOpenFileExplorer.Location = new System.Drawing.Point(582, 0);
            this.btnOpenFileExplorer.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenFileExplorer.Name = "btnOpenFileExplorer";
            this.btnOpenFileExplorer.Size = new System.Drawing.Size(54, 37);
            this.btnOpenFileExplorer.TabIndex = 0;
            this.btnOpenFileExplorer.Text = "...";
            this.btnOpenFileExplorer.UseVisualStyleBackColor = true;
            this.btnOpenFileExplorer.Click += new System.EventHandler(this.btnOpenFileExplorer_Click);
            // 
            // txtFullFileName
            // 
            this.txtFullFileName.Location = new System.Drawing.Point(6, 0);
            this.txtFullFileName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFullFileName.Name = "txtFullFileName";
            this.txtFullFileName.Size = new System.Drawing.Size(564, 32);
            this.txtFullFileName.TabIndex = 1;
            this.txtFullFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullFileName_KeyDown);
            // 
            // ofdFileExplorer
            // 
            this.ofdFileExplorer.CheckFileExists = false;
            this.ofdFileExplorer.FileName = "Folder Selection";
            this.ofdFileExplorer.ValidateNames = false;
            // 
            // ucFileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFullFileName);
            this.Controls.Add(this.btnOpenFileExplorer);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucFileSelector";
            this.Size = new System.Drawing.Size(652, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileExplorer;
        private System.Windows.Forms.TextBox txtFullFileName;
        private System.Windows.Forms.OpenFileDialog ofdFileExplorer;
    }
}
