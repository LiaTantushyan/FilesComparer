using ASCIWebApp.Services;
using FilesComparer.Helpers;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileComparer
{
    public partial class SelectForm : Form
    {
        private static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string FileName = "";

        public SelectForm()
        {
            InitializeComponent();
        }

        private void compareAndDownloadDownload_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uniqueColumns.Text))
            {
                return;
            }
            var dataFromXml = XmlService.GetDataFromXml(Constants.XmlPath, uniqueColumns.Text);
            var dataFromExcel = ExcelService.GetDataFromExcel(Constants.ExcelPath, uniqueColumns.Text);

            if (dataFromXml == null)
            {
                MessageBox.Show($"There are not any {uniqueColumns.Text}s or something is wrong in your file",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (dataFromExcel.Count != default)
            {
                var dataDifference = dataFromExcel.Except(dataFromXml).ToList();

                if (dataDifference.Count != 0)
                {
                    CreateExcelFile(dataDifference);
                }
                else
                {
                    MessageBox.Show($"There are not any different data",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"There are not any {uniqueColumns.Text}s or something is wrong in your file",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void CreateExcelFile(List<string> data)
        {
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("Differences");
                worksheet.DefaultColWidth = 20;
                worksheet.Cells["A1"].Value = uniqueColumns.Text;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A2"].LoadFromCollection(data);
                var row = worksheet.Dimension.End.Row;
                worksheet.Cells[$"A1:A{row}"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                if (SuccesfullySaved(package))
                {
                    FileName = $"\\{DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss")}.xlsx";
                    MessageBox.Show($"Your excel file downloaded succesfully to {DesktopPath}{FileName}!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);

                    compareAndDownloadDownload.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show($"Error while saving excel file to {Directory.GetCurrentDirectory()}!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool SuccesfullySaved(ExcelPackage package)
        {
            try
            {
                package.SaveAs(DesktopPath + $"\\{DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss")}.xlsx");
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void ToMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
