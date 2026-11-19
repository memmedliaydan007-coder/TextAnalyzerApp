namespace TextAnalyzerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResult = new Label();
            txtFilePath = new TextBox();
            btnSelectFile = new Button();
            btnAnalyze = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Metn Fayli";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 231);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(47, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "Netiece";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 42);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(100, 23);
            txtFilePath.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(346, 42);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 3;
            btnSelectFile.Text = "Fayli Sec";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(346, 124);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(75, 23);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Analiz et";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnalyze);
            Controls.Add(btnSelectFile);
            Controls.Add(txtFilePath);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private TextBox txtFilePath;
        private Button btnSelectFile;
        private Button btnAnalyze;
    }
}
