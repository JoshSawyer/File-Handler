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
            this.fileList = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Multiline = true;
            this.fileList.Name = "fileList";
            this.fileList.ReadOnly = true;
            this.fileList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileList.Size = new System.Drawing.Size(388, 284);
            this.fileList.TabIndex = 0;
            this.fileList.WordWrap = false;
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
            this.buttonOption1.Location = new System.Drawing.Point(406, 218);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(366, 23);
            this.buttonOption1.TabIndex = 2;
            this.buttonOption1.Text = "Generate List";
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.ButtonOption1_Click);
            // 
            // deleteFiles
            // 
            this.deleteFiles.Enabled = false;
            this.deleteFiles.Location = new System.Drawing.Point(12, 302);
            this.deleteFiles.Name = "deleteFiles";
            this.deleteFiles.Size = new System.Drawing.Size(184, 47);
            this.deleteFiles.TabIndex = 3;
            this.deleteFiles.Text = "Delete";
            this.deleteFiles.UseVisualStyleBackColor = true;
            this.deleteFiles.Click += new System.EventHandler(this.DeleteFiles_Click);
            // 
            // clearFiles
            // 
            this.clearFiles.Enabled = false;
            this.clearFiles.Location = new System.Drawing.Point(216, 302);
            this.clearFiles.Name = "clearFiles";
            this.clearFiles.Size = new System.Drawing.Size(184, 47);
            this.clearFiles.TabIndex = 4;
            this.clearFiles.Text = "Clear";
            this.clearFiles.UseVisualStyleBackColor = true;
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
            this.browse.Location = new System.Drawing.Point(745, 116);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(27, 20);
            this.browse.TabIndex = 11;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.searchAllSubs);
            this.Controls.Add(this.optionTwoTitle);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.optionOneTitle);
            this.Controls.Add(this.clearFiles);
            this.Controls.Add(this.deleteFiles);
            this.Controls.Add(this.buttonOption1);
            this.Controls.Add(this.dirInput);
            this.Controls.Add(this.fileList);
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

        private System.Windows.Forms.TextBox fileList;
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
    }
}

