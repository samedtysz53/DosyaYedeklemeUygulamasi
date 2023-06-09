namespace DosyaYedeklemeUygulamasi
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            progreslbl = new Label();
            progressBar = new ProgressBar();
            txtDestination = new TextBox();
            txtSource = new TextBox();
            lblDestination = new Label();
            lblSource = new Label();
            backupButton = new Button();
            btnSelectDestination = new Button();
            btnSelectSource = new Button();
            SuspendLayout();
            // 
            // progreslbl
            // 
            progreslbl.AutoSize = true;
            progreslbl.Location = new Point(482, 101);
            progreslbl.Name = "progreslbl";
            progreslbl.Size = new Size(17, 15);
            progreslbl.TabIndex = 17;
            progreslbl.Text = "%";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(7, 119);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(520, 23);
            progressBar.TabIndex = 16;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(217, 47);
            txtDestination.Margin = new Padding(2);
            txtDestination.Name = "txtDestination";
            txtDestination.ReadOnly = true;
            txtDestination.Size = new Size(312, 23);
            txtDestination.TabIndex = 15;
            // 
            // txtSource
            // 
            txtSource.Location = new Point(217, 17);
            txtSource.Margin = new Padding(2);
            txtSource.Name = "txtSource";
            txtSource.ReadOnly = true;
            txtSource.Size = new Size(312, 23);
            txtSource.TabIndex = 14;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(135, 51);
            lblDestination.Margin = new Padding(2, 0, 2, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(84, 15);
            lblDestination.TabIndex = 13;
            lblDestination.Text = "Hedef Klasörü:";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(135, 21);
            lblSource.Margin = new Padding(2, 0, 2, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(90, 15);
            lblSource.TabIndex = 12;
            lblSource.Text = "Kaynak Klasörü:";
            // 
            // backupButton
            // 
            backupButton.Location = new Point(7, 77);
            backupButton.Margin = new Padding(2);
            backupButton.Name = "backupButton";
            backupButton.Size = new Size(117, 22);
            backupButton.TabIndex = 11;
            backupButton.Text = "Yedekle";
            backupButton.UseVisualStyleBackColor = true;
            backupButton.Click += btnBackup_Click;
            // 
            // btnSelectDestination
            // 
            btnSelectDestination.Location = new Point(7, 47);
            btnSelectDestination.Margin = new Padding(2);
            btnSelectDestination.Name = "btnSelectDestination";
            btnSelectDestination.Size = new Size(117, 22);
            btnSelectDestination.TabIndex = 10;
            btnSelectDestination.Text = "Hedef Klasörü Seç";
            btnSelectDestination.UseVisualStyleBackColor = true;
            btnSelectDestination.Click += btnSelectDestination_Click;
            // 
            // btnSelectSource
            // 
            btnSelectSource.Location = new Point(7, 17);
            btnSelectSource.Margin = new Padding(2);
            btnSelectSource.Name = "btnSelectSource";
            btnSelectSource.Size = new Size(117, 22);
            btnSelectSource.TabIndex = 9;
            btnSelectSource.Text = "Kaynak Klasörü Seç";
            btnSelectSource.UseVisualStyleBackColor = true;
            btnSelectSource.Click += btnSelectSource_Click;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 151);
            Controls.Add(progreslbl);
            Controls.Add(progressBar);
            Controls.Add(txtDestination);
            Controls.Add(txtSource);
            Controls.Add(lblDestination);
            Controls.Add(lblSource);
            Controls.Add(backupButton);
            Controls.Add(btnSelectDestination);
            Controls.Add(btnSelectSource);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Backup";
            Text = "Backup";
            Load += Backup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label progreslbl;
        private ProgressBar progressBar;
        private TextBox txtDestination;
        private TextBox txtSource;
        private Label lblDestination;
        private Label lblSource;
        private Button backupButton;
        private Button btnSelectDestination;
        private Button btnSelectSource;
    }
}