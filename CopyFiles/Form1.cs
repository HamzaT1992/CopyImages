using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace CopyFiles
{
    public partial class Form1 : Form
    {
        string[] lines;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTextBtn_Click(object sender, EventArgs e)
        {
            if (loadText.ShowDialog() == DialogResult.OK)
            {
                var txtFile = loadText.FileName;
                textBox1.Text = txtFile;
                lines = File.ReadAllLines(txtFile);
                label5.Text = lines.Length.ToString();
                progressBar1.Maximum = lines.Length;
            }
        }

        private void DstFolderBtn_Click(object sender, EventArgs e)
        {
            if (dstFolder.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = @dstFolder.SelectedPath;
            }
        }

        private void SrcFolderBtn_Click(object sender, EventArgs e)
        {
            if (srcFolder.ShowDialog() == DialogResult.OK)
            {
                string srcFD = @srcFolder.SelectedPath;

                textBox3.Text = srcFD[srcFD.Length - 1] == '\\' ? srcFD.Substring(0, srcFD.Length - 1) : srcFD;
            }
        }

        private async void CopyBtn_Click(object sender, EventArgs e)
        {
            // The Progress<T> constructor captures our UI context,
            //  so the lambda will be run on the UI thread.
            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;
                labelProgress.Text = $"{percent * 100 / lines.Length} %";
                labelLines.Text = $"{percent}/{lines.Length}";
            });

            // DoProcessing is run on the thread pool.
            await Task.Run(() => Copying(progress));
            MessageBox.Show("Done!");
        }

        public void Copying(IProgress<int> progress)
        {
            int i = 0;
            string dst;
            foreach (var line in lines)
            {
                try
                {
                    dst = @line.Replace(textBox3.Text, dstFolder.SelectedPath);
                    Directory.CreateDirectory(Path.GetDirectoryName(dst));
                    if (!File.Exists(dst))
                    {
                        File.Copy(line, dst);
                        logger.Info($"{dst} copié");
                    }
                    else
                        logger.Warn($"{dst} exist déja");

                    }
                catch (Exception ex)
                {
                    logger.Error(ex, line);
                }
                
                if (progress != null)
                    progress.Report(++i);
            }
        }
}
}
