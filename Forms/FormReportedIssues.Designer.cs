namespace MunicipalServiceApp.Forms
{
    partial class FormReportedIssues
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
            this.components = new System.ComponentModel.Container();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.InactivityTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(126, 50);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(432, 34);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Enter += new System.EventHandler(this.txtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(126, 112);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(432, 106);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            this.rtbDescription.Enter += new System.EventHandler(this.rtbDescription_Enter);
            this.rtbDescription.Leave += new System.EventHandler(this.rtbDescription_Leave);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(123, 355);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(56, 16);
            this.lblFilePath.TabIndex = 5;
            this.lblFilePath.Text = "FilePath";
            this.lblFilePath.Visible = false;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities",
            "Public Safety",
            "Transportation",
            "Health Services",
            "Street Lighting",
            "Public Buildings",
            "Environmental Services"});
            this.cbCategory.Location = new System.Drawing.Point(126, 247);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(432, 28);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.Text = "Select a Category";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(126, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(123, 483);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(91, 16);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "Progress Text";
            this.lblProgress.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Image = global::MunicipalServiceApp.Properties.Resources.submitTwo;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(266, 378);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSubmit.Size = new System.Drawing.Size(182, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachFile.Image = global::MunicipalServiceApp.Properties.Resources.attachFile;
            this.btnAttachFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttachFile.Location = new System.Drawing.Point(266, 294);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAttachFile.Size = new System.Drawing.Size(182, 57);
            this.btnAttachFile.TabIndex = 3;
            this.btnAttachFile.Text = "Attach File";
            this.btnAttachFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttachFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // InactivityTimer
            // 
            this.InactivityTimer.Tick += new System.EventHandler(this.InactivityTimer_Tick);
            // 
            // FormReportedIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 544);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnAttachFile);
            this.Name = "FormReportedIssues";
            this.Text = "Reported Issues Form";
            this.Load += new System.EventHandler(this.FormReportedIssues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer InactivityTimer;
    }
}