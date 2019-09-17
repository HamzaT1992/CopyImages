using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFiles
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        string[] lines;
        int Length=0;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        List<FileInfo> allFiles = new List<FileInfo>();
        public RadForm1()
        {
            InitializeComponent();
        }

        private void loadTxtButton_Click(object sender, EventArgs e)
        {
            Length = 0;
            if (openTxtFileDialog.ShowDialog() == DialogResult.OK)
            {
                var txtFile = openTxtFileDialog.FileName;
                loadTxtTextBox.Text = txtFile;
                lines = File.ReadAllLines(txtFile);
                //label5.Text = lines.Length.ToString();
                foreach (var line in lines)
                {
                    try
                    {
                        FileAttributes attr = File.GetAttributes(line);
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            var dir = new DirectoryInfo(line);
                            var files = dir.GetFiles("*.*", SearchOption.AllDirectories);
                            allFiles.AddRange(files);
                        }
                        else
                        {
                            allFiles.Add(new FileInfo(line));
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Length = allFiles.Count;
                copyProgressBar.Maximum = Length;
                labelLines.Text = Length.ToString();
            }
        }

        //private async Task<string> TotalFilesSize()
        //{
        //    totalSize = 0;
        //    foreach (var item in lines)
        //    {
        //        var file = new FileInfo(item);
        //        totalSize += file.Length;
        //    }
        //    string size;
        //    if (totalSize >= 1073741824) size = $"{totalSize / (int)(Math.Pow(1024, 3))} Go";
        //    else if (totalSize >= 1048576) size = $"{totalSize / (int)(Math.Pow(1024, 2))} Mo";
        //    else if (totalSize >= 1024) size = $"{totalSize / 1024} Ko";
        //    else size = $"{totalSize} o";
        //    return size;
        //}

        private void loadDstFButton_Click(object sender, EventArgs e)
        {
            if (dstFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                loadDstFTextBox.Text = @dstFolderBrowserDialog.SelectedPath;
            }
        }

        private void loadSrcFButton_Click(object sender, EventArgs e)
        {
            if (srcFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string srcFD = @srcFolderBrowserDialog.SelectedPath;

                loadSrcFTextBox.Text = srcFD[srcFD.Length - 1] == '\\' ? srcFD.Substring(0, srcFD.Length - 1) : srcFD;
            }
        }

        private async void copyBtn_Click(object sender, EventArgs e)
        {
            if (loadDstFTextBox.Text == "" || loadDstFTextBox.Text == "" || loadTxtTextBox.Text == "")
            {
                MessageBox.Show("Veulliez remplir tous les champs!!");
                return;
            }
            // The Progress<T> constructor captures our UI context,
            //  so the lambda will be run on the UI thread.
            var progress = new Progress<int>(percent =>
            {
                copyProgressBar.Value1 = percent;
                copyProgressBar.Text = $"{percent * 100 / Length} %";
                labelLines.Text = $"{percent}/{Length}";
            });

            // DoProcessing is run on the thread pool.
            await Task.Run(() => Copying(progress));
            MessageBox.Show("Done!");
        }

        public void Copying(IProgress<int> progress)
        {
            int i = 0;

            foreach (var file in allFiles)
            {
                try
                {
                    Cp(file);
                    if (progress != null)
                        progress.Report(++i);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, file.FullName);
                }


            }
        }
        private void Cp(FileInfo file)
        {
            var dst = file.FullName.Replace(loadSrcFTextBox.Text, dstFolderBrowserDialog.SelectedPath);
            Directory.CreateDirectory(Path.GetDirectoryName(dst));
            //var fl = new FileInfo(loadDstFTextBox.Text);

            if (!File.Exists(dst))
            {
                File.Copy(file.FullName, dst);
                logger.Info($"{dst} copié");
            }
            else
                logger.Warn($"{dst} exist déja");
        }
    }
}
