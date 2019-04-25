using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace File_Handler
{
    public partial class Main : Form
    {
        bool debugMode = false;

        string memoryDir;
        string selectedFile;
        bool? memoryOption;
        string memoryFile;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            memoryDir = "";
            memoryOption = null;
            memoryFile = "";
        }

        private string[] GetFiles(string dir, string file, bool allDir)
        {
            memoryDir = dir;
            memoryOption = allDir;
            memoryFile = file;

            try
            {
                if (allDir)
                {
                    return Directory.GetFiles(dir, file, SearchOption.AllDirectories);
                }
                else
                {
                    return Directory.GetFiles(dir, file);
                }
            }
            catch (Exception error)
            {
                string errStr = error.ToString();
                MessageBox.Show(errStr.Substring(errStr.IndexOf(":"), errStr.IndexOf("." + Environment.NewLine)), "Error");
                string[] returnDummy = { "Error" };
                return returnDummy;
            }
        }

        private void ButtonOption1_Click(object sender, EventArgs e)
        {
            string dir = dirInput.Text;

            string[] files;
            try
            {
                if (fileList.Text != "")
                {
                    MessageBox.Show("There is already a file list!", "List Error");
                    return;
                }
                if (!(dirInput.BackColor == Color.SpringGreen && fileInput.BackColor == Color.SpringGreen))
                {
                    MessageBox.Show("Please ensure that both input boxes are green!", "Input Error");
                    return;
                }

                files = GetFiles(dir, fileInput.Text, searchAllSubs.Checked);
                if (files[0] == "Error")
                {
                    return;
                }
            }
            catch (Exception error)
            {
                string errStr = error.ToString();
                MessageBox.Show(errStr.Substring(errStr.IndexOf(":"), errStr.IndexOf("." + Environment.NewLine)), "Error");
                return;
            }

            if (files.Length < 1)
            {
                MessageBox.Show("No files found!", "Directory Error");
                return;
            }

            foreach (string fileDir in files)
            {
                fileList.Items.Add(fileDir);
            }

            deleteFiles.Enabled = true;
            clearFiles.Enabled = true;
            extractAll.Enabled = true;
        }

        private void DeleteFiles_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete these files?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.No)
            {
                return;
            }

            try
            {
                string[] files = GetFiles(memoryDir, memoryFile, memoryOption ?? false);

                if (debugMode)
                {
                    MessageBox.Show("Deletion");
                    MessageBox.Show("Files successfully deleted!", "Success");

                    ClearFiles_Click(sender, e);
                    return;
                }

                foreach (string fileDir in files)
                {
                    File.Delete(fileDir);
                }
            }
            catch (Exception error)
            {
                string errStr = error.ToString();
                MessageBox.Show(errStr.Substring(errStr.IndexOf(":"), errStr.IndexOf("." + Environment.NewLine)), "Error");
                return;
            }

            MessageBox.Show("Files successfully deleted!", "Success");

            fileList.Items.Clear();
            ClearFiles_Click(sender, e);
        }

        private void ClearFiles_Click(object sender, EventArgs e)
        {
            fileList.Items.Clear();
            deleteFiles.Enabled = false;
            clearFiles.Enabled = false;
            clearSelected.Enabled = false;
            deleteFile.Enabled = false;
            extractSelected.Enabled = false;
            extractAll.Enabled = false;
        }

        private void DirInput_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(dirInput.Text))
            {
                dirInput.BackColor = Color.SpringGreen;
            }
            else
            {
                dirInput.BackColor = Color.White;
            }
        }

        private void FileInput_TextChanged(object sender, EventArgs e)
        {
            if (fileInput.Text.IndexOf("*") > -1 ||
                fileInput.Text.IndexOf(".") > -1 && fileInput.Text.Length > fileInput.Text.IndexOf(".") + 1)
            {
                fileInput.BackColor = Color.SpringGreen;
            }
            else
            {
                fileInput.BackColor = Color.White;
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = getFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                dirInput.Text = getFolder.SelectedPath;
            }
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedFile = fileList.SelectedItem.ToString();
                deleteFile.Enabled = true;
                clearSelected.Enabled = true;
                extractSelected.Enabled = true;
            }
            catch { }
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFile != null)
                {
                    File.Delete(selectedFile);
                    fileList.Items.Remove(selectedFile);
                }
                deleteFile.Enabled = false;
                extractSelected.Enabled = false;
                clearSelected.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Access denied!", "Error");
            }
        }

        private void ClearSelected_Click(object sender, EventArgs e)
        {
            if (selectedFile != null)
            {
                fileList.Items.Remove(selectedFile);
            }
            clearSelected.Enabled = false;
            deleteFile.Enabled = false;
            extractSelected.Enabled = false;
        }

        private void FileList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(fileList.SelectedItem.ToString());
            }
            catch { }
        }

        private void ExtractSelected_Click(object sender, EventArgs e)
        {
            DialogResult result = getFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selItem = fileList.SelectedItem.ToString();

                int i;
                for (i = selItem.Length - 1; i >= 0; i--)
                {
                    if (selItem[i] == '\\')
                    {
                        break;
                    }
                }
                string newLoc = getFolder.SelectedPath + selItem.Substring(i, selItem.Length - i);

                try
                {
                    File.Copy(selItem, newLoc);
                    MessageBox.Show("File succesfully copied!", "Success");
                }
                catch
                {
                    MessageBox.Show("File, " + newLoc + ", already exists!", "Error");
                }
            }
        }

        private void ExtractAll_Click(object sender, EventArgs e)
        {
            DialogResult result = getFolder.ShowDialog();

            foreach (string selItem in fileList.Items)
            {
                if (result == DialogResult.OK)
                {
                    int i;
                    for (i = selItem.Length - 1; i >= 0; i--)
                    {
                        if (selItem[i] == '\\')
                        {
                            break;
                        }
                    }
                    string newLoc = getFolder.SelectedPath + selItem.Substring(i, selItem.Length - i);

                    try
                    {
                        File.Copy(selItem, newLoc);
                    }
                    catch
                    {
                        MessageBox.Show("File, " + newLoc + ", already exists!", "Error");
                    }
                }
            }
        }
    }
}
