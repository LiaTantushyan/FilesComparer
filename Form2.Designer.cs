
namespace FileComparer
{
    partial class SelectForm
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
            this.infoText = new System.Windows.Forms.Label();
            this.uniqueColumns = new System.Windows.Forms.ComboBox();
            this.compareAndDownloadDownload = new System.Windows.Forms.Button();
            this.ToMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Segoe UI Symbol", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.infoText.Location = new System.Drawing.Point(70, 66);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(504, 35);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "Select column from dropdown list below";
            // 
            // uniqueColumns
            // 
            this.uniqueColumns.BackColor = System.Drawing.SystemColors.Menu;
            this.uniqueColumns.FormattingEnabled = true;
            this.uniqueColumns.Items.AddRange(new object[] {
            "PassportNum",
            "SocCardNum",
            "LAccountNumber",
            "ANTPType"});
            this.uniqueColumns.Location = new System.Drawing.Point(179, 148);
            this.uniqueColumns.Name = "uniqueColumns";
            this.uniqueColumns.Size = new System.Drawing.Size(225, 28);
            this.uniqueColumns.TabIndex = 1;
            // 
            // compareAndDownloadDownload
            // 
            this.compareAndDownloadDownload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.compareAndDownloadDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compareAndDownloadDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compareAndDownloadDownload.ForeColor = System.Drawing.SystemColors.Window;
            this.compareAndDownloadDownload.Location = new System.Drawing.Point(219, 200);
            this.compareAndDownloadDownload.Name = "compareAndDownloadDownload";
            this.compareAndDownloadDownload.Size = new System.Drawing.Size(139, 44);
            this.compareAndDownloadDownload.TabIndex = 2;
            this.compareAndDownloadDownload.Text = "Compare";
            this.compareAndDownloadDownload.UseVisualStyleBackColor = false;
            this.compareAndDownloadDownload.Click += new System.EventHandler(this.compareAndDownloadDownload_Click_1);
            // 
            // ToMainButton
            // 
            this.ToMainButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ToMainButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ToMainButton.FlatAppearance.BorderSize = 0;
            this.ToMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToMainButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.ToMainButton.Location = new System.Drawing.Point(0, 0);
            this.ToMainButton.Name = "ToMainButton";
            this.ToMainButton.Size = new System.Drawing.Size(113, 41);
            this.ToMainButton.TabIndex = 3;
            this.ToMainButton.Text = "go back";
            this.ToMainButton.UseVisualStyleBackColor = false;
            this.ToMainButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(628, 343);
            this.Controls.Add(this.ToMainButton);
            this.Controls.Add(this.compareAndDownloadDownload);
            this.Controls.Add(this.uniqueColumns);
            this.Controls.Add(this.infoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileComparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.ComboBox uniqueColumns;
        private System.Windows.Forms.Button compareAndDownloadDownload;
        private System.Windows.Forms.Button compareAndDownloadDownload_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ToMainButton;
    }
}