namespace File_Handler
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dirInput = new System.Windows.Forms.TextBox();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.deleteFiles = new System.Windows.Forms.Button();
            this.clearFiles = new System.Windows.Forms.Button();
            this.optionOneTitle = new System.Windows.Forms.Label();
            this.optionTwoTitle = new System.Windows.Forms.Label();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.searchAllSubs = new System.Windows.Forms.CheckBox();
            this.browse = new System.Windows.Forms.Button();
            this.getFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.fileList = new System.Windows.Forms.ListBox();
            this.deleteFile = new System.Windows.Forms.Button();
            this.clearSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dirInput
            // 
            this.dirInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dirInput.BackColor = System.Drawing.Color.SpringGreen;
            this.dirInput.ForeColor = System.Drawing.Color.Black;
            this.dirInput.Location = new System.Drawing.Point(406, 116);
            this.dirInput.MaxLength = 200;
            this.dirInput.Name = "dirInput";
            this.dirInput.Size = new System.Drawing.Size(333, 20);
            this.dirInput.TabIndex = 1;
            this.dirInput.Tag = "";
            this.dirInput.Text = "C:\\";
            this.dirInput.TextChanged += new System.EventHandler(this.DirInput_TextChanged);
            // 
            // buttonOption1
            // 
            this.buttonOption1.BackColor = System.Drawing.Color.White;
            this.buttonOption1.Location = new System.Drawing.Point(406, 218);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(366, 23);
            this.buttonOption1.TabIndex = 2;
            this.buttonOption1.Text = "Generate List";
            this.buttonOption1.UseVisualStyleBackColor = false;
            this.buttonOption1.Click += new System.EventHandler(this.ButtonOption1_Click);
            // 
            // deleteFiles
            // 
            this.deleteFiles.BackColor = System.Drawing.Color.White;
            this.deleteFiles.Enabled = false;
            this.deleteFiles.Location = new System.Drawing.Point(12, 331);
            this.deleteFiles.Name = "deleteFiles";
            this.deleteFiles.Size = new System.Drawing.Size(184, 24);
            this.deleteFiles.TabIndex = 3;
            this.deleteFiles.Text = "Delete All";
            this.deleteFiles.UseVisualStyleBackColor = false;
            this.deleteFiles.Click += new System.EventHandler(this.DeleteFiles_Click);
            // 
            // clearFiles
            // 
            this.clearFiles.BackColor = System.Drawing.Color.White;
            this.clearFiles.Enabled = false;
            this.clearFiles.Location = new System.Drawing.Point(216, 331);
            this.clearFiles.Name = "clearFiles";
            this.clearFiles.Size = new System.Drawing.Size(184, 24);
            this.clearFiles.TabIndex = 4;
            this.clearFiles.Text = "Clear All";
            this.clearFiles.UseVisualStyleBackColor = false;
            this.clearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // optionOneTitle
            // 
            this.optionOneTitle.AutoSize = true;
            this.optionOneTitle.Location = new System.Drawing.Point(406, 99);
            this.optionOneTitle.Name = "optionOneTitle";
            this.optionOneTitle.Size = new System.Drawing.Size(77, 13);
            this.optionOneTitle.TabIndex = 5;
            this.optionOneTitle.Text = "Enter Directory";
            // 
            // optionTwoTitle
            // 
            this.optionTwoTitle.AutoSize = true;
            this.optionTwoTitle.Location = new System.Drawing.Point(406, 146);
            this.optionTwoTitle.Name = "optionTwoTitle";
            this.optionTwoTitle.Size = new System.Drawing.Size(229, 13);
            this.optionTwoTitle.TabIndex = 7;
            this.optionTwoTitle.Text = "Enter File or Extention (e.g. \"hello.txt\" or \"*.txt\")";
            // 
            // fileInput
            // 
            this.fileInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInput.BackColor = System.Drawing.Color.SpringGreen;
            this.fileInput.Location = new System.Drawing.Point(406, 163);
            this.fileInput.MaxLength = 200;
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(366, 20);
            this.fileInput.TabIndex = 6;
            this.fileInput.Tag = "";
            this.fileInput.Text = "*";
            this.fileInput.TextChanged += new System.EventHandler(this.FileInput_TextChanged);
            // 
            // searchAllSubs
            // 
            this.searchAllSubs.AutoSize = true;
            this.searchAllSubs.Location = new System.Drawing.Point(406, 195);
            this.searchAllSubs.Name = "searchAllSubs";
            this.searchAllSubs.Size = new System.Drawing.Size(144, 17);
            this.searchAllSubs.TabIndex = 10;
            this.searchAllSubs.Text = "Search All Subdirectories";
            this.searchAllSubs.UseVisualStyleBackColor = true;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(745, 116);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(27, 20);
            this.browse.TabIndex = 11;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(388, 290);
            this.fileList.TabIndex = 12;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // deleteFile
            // 
            this.deleteFile.BackColor = System.Drawing.Color.White;
            this.deleteFile.Enabled = false;
            this.deleteFile.Location = new System.Drawing.Point(12, 308);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(184, 24);
            this.deleteFile.TabIndex = 13;
            this.deleteFile.Text = "Delete Selected";
            this.deleteFile.UseVisualStyleBackColor = false;
            this.deleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // clearSelected
            // 
            this.clearSelected.BackColor = System.Drawing.Color.White;
            this.clearSelected.Enabled = false;
            this.clearSelected.Location = new System.Drawing.Point(216, 308);
            this.clearSelected.Name = "clearSelected";
            this.clearSelected.Size = new System.Drawing.Size(184, 24);
            this.clearSelected.TabIndex = 14;
            this.clearSelected.Text = "Clear Selected";
            this.clearSelected.UseVisualStyleBackColor = false;
            this.clearSelected.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.clearSelected);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.searchAllSubs);
            this.Controls.Add(this.optionTwoTitle);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.optionOneTitle);
            this.Controls.Add(this.clearFiles);
            this.Controls.Add(this.deleteFiles);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.dirInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "File Handler";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dirInput;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button deleteFiles;
        private System.Windows.Forms.Button clearFiles;
        private System.Windows.Forms.Label optionOneTitle;
        private System.Windows.Forms.Label optionTwoTitle;
        private System.Windows.Forms.TextBox fileInput;
        private System.Windows.Forms.CheckBox searchAllSubs;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog getFolder;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Button clearSelected;
    }
}

