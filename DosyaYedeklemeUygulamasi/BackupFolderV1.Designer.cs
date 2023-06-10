namespace DosyaYedeklemeUygulamasi
{
    partial class BackupFolderV1
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
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSource = new TextBox();
            txtDestination = new TextBox();
            progressBar = new ProgressBar();
            button3 = new Button();
            button4 = new Button();
            progreslbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(145, 73);
            button1.TabIndex = 0;
            button1.Text = "SystemBackup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 91);
            button2.Name = "button2";
            button2.Size = new Size(145, 73);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(163, 20);
            button5.Name = "button5";
            button5.Size = new Size(104, 32);
            button5.TabIndex = 4;
            button5.Text = "Kaynak dosya:";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Kaynak dosya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 65);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 6;
            label2.Text = "Hedef Dosya:";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(361, 21);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(181, 23);
            txtSource.TabIndex = 7;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(361, 62);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(181, 23);
            txtDestination.TabIndex = 8;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(163, 137);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(372, 23);
            progressBar.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(163, 61);
            button3.Name = "button3";
            button3.Size = new Size(104, 32);
            button3.TabIndex = 10;
            button3.Text = "Hedef dosya:";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(163, 99);
            button4.Name = "button4";
            button4.Size = new Size(104, 32);
            button4.TabIndex = 11;
            button4.Text = "yedekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // progreslbl
            // 
            progreslbl.AutoSize = true;
            progreslbl.Location = new Point(494, 113);
            progreslbl.Name = "progreslbl";
            progreslbl.Size = new Size(17, 15);
            progreslbl.TabIndex = 12;
            progreslbl.Text = "%";
            // 
            // BackupFolderV1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 166);
            Controls.Add(progreslbl);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(progressBar);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BackupFolderV1";
            Text = "BackupFolderV1";
            Load += BackupFolderV1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button5;
        private Label label1;
        private Label label2;
        private TextBox txtSource;
        private TextBox txtDestination;
        private ProgressBar progressBar;
        private Button button3;
        private Button button4;
        private Label progreslbl;
    }
}