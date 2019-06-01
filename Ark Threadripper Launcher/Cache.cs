using System;
using System.IO;
using System.Windows.Forms;

namespace Ark_Threadripper_Launcher
{
    public partial class Cache : Form
    {


        public Cache()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteDirectory(Path.GetTempPath());
            this.Hide();
        }
        bool DeleteDirectory(string directoryPath)
        {
            // whether or not to delete THIS directory after the files are deleted
            // this is set to false if there are files inside that don't meet the 24h threshold
            bool deleteParent = true;
            foreach (var fileName in Directory.GetFiles(directoryPath))
            {
                try
                {
                    // only delete file if it was last modified over 24 hours ago
                    if (File.GetLastWriteTime(fileName).AddHours(24) <= DateTime.Now)
                    {
                        File.Delete(fileName);
                    }
                    else
                    {
                        deleteParent = false;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    deleteParent = false;
                }
            }

            // recursively delete all subdirectories
            foreach (var directoryName in Directory.GetDirectories(directoryPath))
            {
                // if and subdirectories aren't able to be deleted, don't delete this one either
                if (!DeleteDirectory(directoryName))
                {
                    deleteParent = false;
                }
            }

            if (deleteParent)
            {
                Directory.Delete(directoryPath);
            }

            return deleteParent;    // return whether or not we were able to delete all the directories
        }

        private void Cache_Load(object sender, EventArgs e)
        {
            this.FormClosing += Cache_FormClosing; // occurs before closing of the form
            this.FormClosed += Cache_FormClosed; // occurs after the closing of the form
        }
        private void Cache_FormClosed(object sender, FormClosedEventArgs e)
        {
            // your code here to do something before closing the form
        }

        private void Cache_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}