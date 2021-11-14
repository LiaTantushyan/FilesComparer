using ASCIWebApp.Services;
using FileComparer.Helpers;
using FilesComparer.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void xmlUploadButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                xmlPath.Text = dialog.FileName;
            }
            Constants.XmlPath = xmlPath.Text;
        }

        private void excelUploadButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                excelPath.Text = dialog.FileName;
            }
            Constants.ExcelPath = excelPath.Text;
        }
        private void validateButton_Click(object sender, EventArgs e)
        {
            invalidxmlButton.Text = default;
            invalidexcelButton.Text = default;
            if (!xmlPath.Text.IsValid(FileTypes.Xml))
            {
                xmlPath.Text = default;
                invalidxmlButton.Text = "Invalid Xml file";
                return;
            }
            if (!excelPath.Text.IsValid(FileTypes.Excel))
            {
                excelPath.Text = default;
                invalidexcelButton.Text = "Invalid Excel file";
                return;
            }

            this.Hide();
            var form2 = new SelectForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}