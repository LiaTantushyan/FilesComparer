
namespace FileComparer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xmlPath = new System.Windows.Forms.TextBox();
            this.excelPath = new System.Windows.Forms.TextBox();
            this.xmlUploadButton = new System.Windows.Forms.Button();
            this.excelUploadButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.invalidxmlButton = new System.Windows.Forms.Label();
            this.invalidexcelButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmlPath
            // 
            this.xmlPath.Location = new System.Drawing.Point(67, 66);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.Size = new System.Drawing.Size(356, 27);
            this.xmlPath.TabIndex = 0;
            // 
            // excelPath
            // 
            this.excelPath.Location = new System.Drawing.Point(67, 130);
            this.excelPath.Name = "excelPath";
            this.excelPath.Size = new System.Drawing.Size(356, 27);
            this.excelPath.TabIndex = 1;
            // 
            // xmlUploadButton
            // 
            this.xmlUploadButton.Location = new System.Drawing.Point(442, 64);
            this.xmlUploadButton.Name = "xmlUploadButton";
            this.xmlUploadButton.Size = new System.Drawing.Size(151, 29);
            this.xmlUploadButton.TabIndex = 2;
            this.xmlUploadButton.Text = "Choose XML";
            this.xmlUploadButton.UseVisualStyleBackColor = true;
            this.xmlUploadButton.Click += new System.EventHandler(this.xmlUploadButtonClick);
            // 
            // excelUploadButton
            // 
            this.excelUploadButton.Location = new System.Drawing.Point(442, 128);
            this.excelUploadButton.Name = "excelUploadButton";
            this.excelUploadButton.Size = new System.Drawing.Size(151, 29);
            this.excelUploadButton.TabIndex = 3;
            this.excelUploadButton.Text = "Choose Excel";
            this.excelUploadButton.UseVisualStyleBackColor = true;
            this.excelUploadButton.Click += new System.EventHandler(this.excelUploadButtonClick);
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.validateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.validateButton.FlatAppearance.BorderSize = 0;
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validateButton.ForeColor = System.Drawing.SystemColors.Info;
            this.validateButton.Location = new System.Drawing.Point(211, 204);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(192, 37);
            this.validateButton.TabIndex = 4;
            this.validateButton.Text = "Continue";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // invalidxmlButton
            // 
            this.invalidxmlButton.AutoSize = true;
            this.invalidxmlButton.ForeColor = System.Drawing.Color.Red;
            this.invalidxmlButton.Location = new System.Drawing.Point(67, 96);
            this.invalidxmlButton.Name = "invalidxmlButton";
            this.invalidxmlButton.Size = new System.Drawing.Size(0, 20);
            this.invalidxmlButton.TabIndex = 5;
            // 
            // invalidexcelButton
            // 
            this.invalidexcelButton.AutoSize = true;
            this.invalidexcelButton.ForeColor = System.Drawing.Color.Red;
            this.invalidexcelButton.Location = new System.Drawing.Point(67, 160);
            this.invalidexcelButton.Name = "invalidexcelButton";
            this.invalidexcelButton.Size = new System.Drawing.Size(0, 20);
            this.invalidexcelButton.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 343);
            this.Controls.Add(this.invalidexcelButton);
            this.Controls.Add(this.invalidxmlButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.excelUploadButton);
            this.Controls.Add(this.xmlUploadButton);
            this.Controls.Add(this.excelPath);
            this.Controls.Add(this.xmlPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlPath;
        private System.Windows.Forms.TextBox excelPath;
        private System.Windows.Forms.Button xmlUploadButton;
        private System.Windows.Forms.Button excelUploadButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label invalidxmlButton;
        private System.Windows.Forms.Label invalidexcelButton;
    }
}

