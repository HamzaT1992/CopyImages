namespace CopyFiles
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadTextBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dstFolderBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.srcFolderBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.copyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadText = new System.Windows.Forms.OpenFileDialog();
            this.dstFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.srcFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelLines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadTextBtn
            // 
            this.loadTextBtn.Location = new System.Drawing.Point(278, 35);
            this.loadTextBtn.Name = "loadTextBtn";
            this.loadTextBtn.Size = new System.Drawing.Size(106, 23);
            this.loadTextBtn.TabIndex = 0;
            this.loadTextBtn.Text = "Open";
            this.loadTextBtn.UseVisualStyleBackColor = true;
            this.loadTextBtn.Click += new System.EventHandler(this.LoadTextBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Load Text:";
            // 
            // dstFolderBtn
            // 
            this.dstFolderBtn.Location = new System.Drawing.Point(278, 93);
            this.dstFolderBtn.Name = "dstFolderBtn";
            this.dstFolderBtn.Size = new System.Drawing.Size(106, 23);
            this.dstFolderBtn.TabIndex = 0;
            this.dstFolderBtn.Text = "Open";
            this.dstFolderBtn.UseVisualStyleBackColor = true;
            this.dstFolderBtn.Click += new System.EventHandler(this.DstFolderBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Folder:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path Containing Images:";
            // 
            // srcFolderBtn
            // 
            this.srcFolderBtn.Location = new System.Drawing.Point(278, 151);
            this.srcFolderBtn.Name = "srcFolderBtn";
            this.srcFolderBtn.Size = new System.Drawing.Size(106, 23);
            this.srcFolderBtn.TabIndex = 0;
            this.srcFolderBtn.Text = "Open";
            this.srcFolderBtn.UseVisualStyleBackColor = true;
            this.srcFolderBtn.Click += new System.EventHandler(this.SrcFolderBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 214);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(278, 276);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(106, 23);
            this.copyBtn.TabIndex = 0;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Files :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // loadText
            // 
            this.loadText.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.loadText.Title = "Select Text File";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(181, 244);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 13);
            this.labelProgress.TabIndex = 5;
            // 
            // labelLines
            // 
            this.labelLines.AutoSize = true;
            this.labelLines.Location = new System.Drawing.Point(12, 244);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(13, 13);
            this.labelLines.TabIndex = 4;
            this.labelLines.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 321);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelLines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.srcFolderBtn);
            this.Controls.Add(this.dstFolderBtn);
            this.Controls.Add(this.loadTextBtn);
            this.Name = "Form1";
            this.Text = "Copy images";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadTextBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dstFolderBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button srcFolderBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog loadText;
        private System.Windows.Forms.FolderBrowserDialog dstFolder;
        private System.Windows.Forms.FolderBrowserDialog srcFolder;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelLines;
    }
}

