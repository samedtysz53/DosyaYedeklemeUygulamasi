using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaYedeklemeUygulamasi
{
    public partial class Backup : Form
    {
        public string Source;
        public string Target;
        private int totalFiles;
        private int filesProcessed;
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            Source = dialog.SelectedPath;
            txtSource.Text = Source;

        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            Target = dialog.SelectedPath;
            txtDestination.Text = Target;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string sourceFolder = txtSource.Text;
            string destinationFolder = txtDestination.Text;
            if (sourceFolder != null && destinationFolder != null)
            {
                totalFiles = CountFiles(sourceFolder);
            }
            else { MessageBox.Show("lütfen hedef dizin ve kaynak dizin belirtin"); }
            // İlerleme çubuğunu hazırla
            progressBar.Minimum = 0;
            progressBar.Maximum = totalFiles;
            progressBar.Step = 1;
            progressBar.Value = 0;
            if (sourceFolder != null && destinationFolder != null)
            {
                // Yedekleme işlemini başlat
                BackupFolder(sourceFolder, destinationFolder);
            }
            else { MessageBox.Show("lütfen hedef dizin ve kaynak dizin belirtin"); }

            // Yedekleme tamamlandığında mesaj göster
            MessageBox.Show("Yedekleme tamamlandı.");
        }

        private int CountFiles(string directory)
        {
            int count = Directory.GetFiles(directory).Length;
            string[] subDirectories = Directory.GetDirectories(directory);

            foreach (string subDirectory in subDirectories)
            {
                count += CountFiles(subDirectory);
            }

            return count;
        }


        private void BackupFolder(string sourceFolder, string destinationFolder)
        {
           
            try
            {
                // Kaynak klasördeki dosyaları al
                string[] files = Directory.GetFiles(sourceFolder);

                // Kaynak klasördeki her bir dosya için
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationPath = Path.Combine(destinationFolder, fileName);

                    // Dosyayı kopyala
                    File.Copy(file, destinationPath, true);

                    // İlerlemeyi güncelle
                    filesProcessed++;
                    progressBar.Value = filesProcessed;
                    progreslbl.Text = progressBar.Value.ToString();
                    int percentage = (int)((float)filesProcessed / totalFiles * 100);
                    progreslbl.Text =percentage.ToString() + "%";//progressbar yüzdesini label da göster
                    Application.DoEvents();
                }

                // Kaynak klasördeki alt dizinler için yedeklemeyi tekrarla
                string[] subDirectories = Directory.GetDirectories(sourceFolder);
                foreach (string subDirectory in subDirectories)
                {
                    string directoryName = Path.GetFileName(subDirectory);
                    string destinationPath = Path.Combine(destinationFolder, directoryName);

                    // Alt dizini oluştur
                    Directory.CreateDirectory(destinationPath);

                    // Alt dizini ve içeriğini yedekle
                    BackupFolder(subDirectory, destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            }
            
        }


    }
 
