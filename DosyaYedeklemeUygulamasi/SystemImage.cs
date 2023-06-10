using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaYedeklemeUygulamasi
{
    public partial class SystemImage : Form
    {
        public SystemImage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            GetDiskSize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void SystemImage_Load(object sender, EventArgs e)
        {
            GetDiskSize();
        }

        public void GetDiskSize()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            listBox1.Items.Clear();
            int driveNumber = 0; // Disk numarasını burada tutacağız
            foreach (DriveInfo drive in drives.OrderBy(d => d.Name)) // Diskleri alfabetik sırayla alıyoruz
            {
                if (drive.IsReady)
                {
                    long totalSize = drive.TotalSize;
                    long freespace = drive.TotalFreeSpace;
                    long usedspace = totalSize - freespace;
                    string driverInfo = $"Disk No: {driveNumber}: {drive.Name} - Toplam boyut: {FormatSize(totalSize)} - kullanılan alan: {FormatSize(usedspace)}";
                    listBox1.Items.Add(driverInfo);
                }
                driveNumber++; // Her bir döngüde disk numarasını arttırıyoruz
            }
        }



        private string FormatSize(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double size = bytes;

            while (size >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                size /= 1024;
                suffixIndex++;
            }

            return $"{size:0.##} {suffixes[suffixIndex]}";

        }


    }
}
