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

namespace FileChecker
{

    public partial class Form1 : Form
    {
        string path1;
        string path2;
        string outputPath;

        public Form1()
        {
            InitializeComponent();
            listOptions.DataSource = new string[] { "GetDiferences", "GetAlikes" };
        }

        private void btnBrowsePath1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath1.Text = openFileDialog1.FileName;
                path1 = txtPath1.Text;
            }
        }

        private void btnBrowsePath2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath2.Text = openFileDialog1.FileName;
                path2 = txtPath2.Text;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = openFileDialog1.FileName;
                outputPath = txtOutputPath.Text;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(path1) || String.IsNullOrEmpty(path2) || String.IsNullOrEmpty(outputPath))
            { MessageBox.Show("You need to set the paths first!"); }
            else
            {
                switch (listOptions.SelectedIndex)
                {
                    case 0:
                        ContentChecker.WriteDiferences(path1, path2, outputPath);
                        MessageBox.Show("All Done");
                        break;
                    case 1:
                        ContentChecker.WriteAlikes(path1, path2, outputPath);
                        MessageBox.Show("All Done");
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtPath1_TextChanged(object sender, EventArgs e)
        {
            path1 = txtPath1.Text;
        }

        private void txtPath2_TextChanged(object sender, EventArgs e)
        {
            path2 = txtPath2.Text;
        }

        private void txtOutputPath_TextChanged(object sender, EventArgs e)
        {
            outputPath = txtOutputPath.Text;
        }

    }
}
