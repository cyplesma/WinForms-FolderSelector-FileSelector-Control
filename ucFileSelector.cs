using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace TVShowSeasonFileStructureSetup
{
    public partial class ucFileSelector : UserControl
    {
        public event EventHandler FileNameChanged;

        private string sFileType = "";
        private bool bSelectFolder = false;
        private string _lastCommittedFileName = "";

        public ucFileSelector()
        {
            InitializeComponent();

            txtFullFileName.Leave += txtFullFileName_Leave;
        }

        public string FileType
        {
            get { return sFileType; }
            set { sFileType = value ?? ""; }
        }

        public bool SelectFolder
        {
            get { return bSelectFolder; }
            set { bSelectFolder = value; }
        }

        public override string Text
        {
            get { return txtFullFileName.Text; }
            set
            {
                txtFullFileName.Text = value ?? "";
                CommitFileNameChange();
            }
        }

        public string FileName
        {
            get { return txtFullFileName.Text; }
            set
            {
                txtFullFileName.Text = value ?? "";
                CommitFileNameChange();
            }
        }

        private void txtFullFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommitFileNameChange();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnOpenFileExplorer_Click(object sender, EventArgs e)
        {
            if (SelectFolder)
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select Folder";

                    if (Directory.Exists(txtFullFileName.Text))
                        fbd.SelectedPath = txtFullFileName.Text;

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        txtFullFileName.Text = fbd.SelectedPath;
                        CommitFileNameChange();
                    }
                }
            }
            else
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (string.IsNullOrEmpty(sFileType))
                        ofd.Filter = "All Files (*.*)|*.*";
                    else
                        ofd.Filter = sFileType;

                    if (File.Exists(txtFullFileName.Text))
                        ofd.FileName = txtFullFileName.Text;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txtFullFileName.Text = ofd.FileName;
                        CommitFileNameChange();
                    }
                }
            }
        }

        private void txtFullFileName_Leave(object sender, EventArgs e)
        {
            CommitFileNameChange();
        }

        private void CommitFileNameChange()
        {
            string currentValue = txtFullFileName.Text ?? "";

            if (string.Equals(currentValue, _lastCommittedFileName, StringComparison.Ordinal))
                return;

            _lastCommittedFileName = currentValue;
            OnFileNameChanged(EventArgs.Empty);
        }

        protected virtual void OnFileNameChanged(EventArgs e)
        {
            FileNameChanged?.Invoke(this, e);
        }

        private void ucFileSelector_Resize(object sender, EventArgs e)
        {
            btnOpenFileExplorer.Left = this.Width - (btnOpenFileExplorer.Width + 10);
            txtFullFileName.Width = btnOpenFileExplorer.Left - 10;
        }

    }
}