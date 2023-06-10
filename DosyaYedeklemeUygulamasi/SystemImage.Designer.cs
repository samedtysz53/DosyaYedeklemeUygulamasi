namespace DosyaYedeklemeUygulamasi
{
    partial class SystemImage
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
            listBox1 = new ListBox();
            button3 = new Button();
            progressBar = new ProgressBar();
            progreslbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 35);
            button1.Name = "button1";
            button1.Size = new Size(161, 62);
            button1.TabIndex = 21;
            button1.Text = "SystemImage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(243, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(689, 139);
            listBox1.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(12, 112);
            button3.Name = "button3";
            button3.Size = new Size(161, 62);
            button3.TabIndex = 22;
            button3.Text = "Yenile";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(243, 183);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(689, 23);
            progressBar.TabIndex = 23;
            // 
            // progreslbl
            // 
            progreslbl.AutoSize = true;
            progreslbl.Location = new Point(884, 165);
            progreslbl.Name = "progreslbl";
            progreslbl.Size = new Size(17, 15);
            progreslbl.TabIndex = 24;
            progreslbl.Text = "%";
            // 
            // SystemImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 234);
            Controls.Add(progreslbl);
            Controls.Add(progressBar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SystemImage";
            Text = "SystemImage";
            Load += SystemImage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button3;
        private ProgressBar progressBar;
        private Label progreslbl;
    }
}