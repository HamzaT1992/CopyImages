namespace CopyFiles
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.loadDstFButton = new Telerik.WinControls.UI.RadButton();
            this.loadDstFTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.loadTxtButton = new Telerik.WinControls.UI.RadButton();
            this.loadTxtTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.loadSrcFButton = new Telerik.WinControls.UI.RadButton();
            this.loadSrcFTextBox = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.copyProgressBar = new Telerik.WinControls.UI.RadProgressBar();
            this.labelLines = new Telerik.WinControls.UI.RadLabel();
            this.openTxtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.srcFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dstFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.copyBtn = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.loadDstFButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDstFTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTxtButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTxtTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSrcFButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSrcFTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // loadDstFButton
            // 
            this.loadDstFButton.Location = new System.Drawing.Point(317, 113);
            this.loadDstFButton.Name = "loadDstFButton";
            this.loadDstFButton.Size = new System.Drawing.Size(110, 24);
            this.loadDstFButton.TabIndex = 0;
            this.loadDstFButton.Text = "Open";
            this.loadDstFButton.Click += new System.EventHandler(this.loadDstFButton_Click);
            // 
            // loadDstFTextBox
            // 
            this.loadDstFTextBox.Location = new System.Drawing.Point(13, 114);
            this.loadDstFTextBox.Name = "loadDstFTextBox";
            this.loadDstFTextBox.Size = new System.Drawing.Size(292, 22);
            this.loadDstFTextBox.TabIndex = 1;
            // 
            // loadTxtButton
            // 
            this.loadTxtButton.Location = new System.Drawing.Point(317, 44);
            this.loadTxtButton.Name = "loadTxtButton";
            this.loadTxtButton.Size = new System.Drawing.Size(110, 24);
            this.loadTxtButton.TabIndex = 0;
            this.loadTxtButton.Text = "Open";
            this.loadTxtButton.Click += new System.EventHandler(this.loadTxtButton_Click);
            // 
            // loadTxtTextBox
            // 
            this.loadTxtTextBox.Location = new System.Drawing.Point(13, 45);
            this.loadTxtTextBox.Name = "loadTxtTextBox";
            this.loadTxtTextBox.Size = new System.Drawing.Size(292, 22);
            this.loadTxtTextBox.TabIndex = 1;
            // 
            // loadSrcFButton
            // 
            this.loadSrcFButton.Location = new System.Drawing.Point(317, 181);
            this.loadSrcFButton.Name = "loadSrcFButton";
            this.loadSrcFButton.Size = new System.Drawing.Size(110, 24);
            this.loadSrcFButton.TabIndex = 0;
            this.loadSrcFButton.Text = "Open";
            this.loadSrcFButton.Click += new System.EventHandler(this.loadSrcFButton_Click);
            // 
            // loadSrcFTextBox
            // 
            this.loadSrcFTextBox.Location = new System.Drawing.Point(13, 182);
            this.loadSrcFTextBox.Name = "loadSrcFTextBox";
            this.loadSrcFTextBox.Size = new System.Drawing.Size(292, 22);
            this.loadSrcFTextBox.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Load Text:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 89);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(100, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Destination Folder:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 157);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(128, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Path Containing Images:";
            // 
            // copyProgressBar
            // 
            this.copyProgressBar.Location = new System.Drawing.Point(13, 244);
            this.copyProgressBar.Name = "copyProgressBar";
            this.copyProgressBar.Size = new System.Drawing.Size(414, 30);
            this.copyProgressBar.TabIndex = 3;
            this.copyProgressBar.Text = "0%";
            // 
            // labelLines
            // 
            this.labelLines.Location = new System.Drawing.Point(8, 280);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(2, 2);
            this.labelLines.TabIndex = 2;
            // 
            // openTxtFileDialog
            // 
            this.openTxtFileDialog.Filter = "Text Files|*.txt";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(317, 318);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(110, 24);
            this.copyBtn.TabIndex = 0;
            this.copyBtn.Text = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 358);
            this.Controls.Add(this.copyProgressBar);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.labelLines);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.loadSrcFTextBox);
            this.Controls.Add(this.loadTxtTextBox);
            this.Controls.Add(this.loadDstFTextBox);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.loadSrcFButton);
            this.Controls.Add(this.loadTxtButton);
            this.Controls.Add(this.loadDstFButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Copy Images";
            ((System.ComponentModel.ISupportInitialize)(this.loadDstFButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDstFTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTxtButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadTxtTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSrcFButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSrcFTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton loadDstFButton;
        private Telerik.WinControls.UI.RadTextBoxControl loadDstFTextBox;
        private Telerik.WinControls.UI.RadButton loadTxtButton;
        private Telerik.WinControls.UI.RadTextBoxControl loadTxtTextBox;
        private Telerik.WinControls.UI.RadButton loadSrcFButton;
        private Telerik.WinControls.UI.RadTextBoxControl loadSrcFTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadProgressBar copyProgressBar;
        private Telerik.WinControls.UI.RadLabel labelLines;
        private System.Windows.Forms.OpenFileDialog openTxtFileDialog;
        private System.Windows.Forms.FolderBrowserDialog srcFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog dstFolderBrowserDialog;
        private Telerik.WinControls.UI.RadButton copyBtn;
    }
}
