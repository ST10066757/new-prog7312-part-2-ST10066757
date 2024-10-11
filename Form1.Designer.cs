namespace MunicipalServiceApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnLocalEvent = new System.Windows.Forms.Button();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Location = new System.Drawing.Point(0, 0);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(75, 23);
            this.btnReportIssues.TabIndex = 4;
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.Location = new System.Drawing.Point(0, 0);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(75, 23);
            this.btnLocalEvents.TabIndex = 6;
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(0, 0);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(75, 23);
            this.btnServiceRequestStatus.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Navy;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnService);
            this.panelMenu.Controls.Add(this.btnLocalEvent);
            this.panelMenu.Controls.Add(this.btnReportIssue);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 485);
            this.panelMenu.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::MunicipalServiceApp.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 80);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.Enabled = false;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.Image = global::MunicipalServiceApp.Properties.Resources.status;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 240);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnService.Size = new System.Drawing.Size(220, 80);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Service Request Status";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // btnLocalEvent
            // 
            this.btnLocalEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocalEvent.FlatAppearance.BorderSize = 0;
            this.btnLocalEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvent.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLocalEvent.Image = global::MunicipalServiceApp.Properties.Resources._event;
            this.btnLocalEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEvent.Location = new System.Drawing.Point(0, 160);
            this.btnLocalEvent.Name = "btnLocalEvent";
            this.btnLocalEvent.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLocalEvent.Size = new System.Drawing.Size(220, 80);
            this.btnLocalEvent.TabIndex = 2;
            this.btnLocalEvent.Text = "Local Events and Announcements";
            this.btnLocalEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalEvent.UseVisualStyleBackColor = true;
            this.btnLocalEvent.Click += new System.EventHandler(this.btnLocalEvent_Click);
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportIssue.FlatAppearance.BorderSize = 0;
            this.btnReportIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssue.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssue.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportIssue.Image = global::MunicipalServiceApp.Properties.Resources.form;
            this.btnReportIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssue.Location = new System.Drawing.Point(0, 80);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReportIssue.Size = new System.Drawing.Size(220, 80);
            this.btnReportIssue.TabIndex = 1;
            this.btnReportIssue.Text = "Report Issues";
            this.btnReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.BackgroundImage = global::MunicipalServiceApp.Properties.Resources.municipalIcon;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(592, 80);
            this.panelTitle.TabIndex = 7;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::MunicipalServiceApp.Properties.Resources.close;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(221, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(130, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Main Menu";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Controls.Add(this.label1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(592, 405);
            this.panelDesktopPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MunicipalServiceApp.Properties.Resources.municipalLogo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Municipal Services Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 485);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Municipal Services Application";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnLocalEvent;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

