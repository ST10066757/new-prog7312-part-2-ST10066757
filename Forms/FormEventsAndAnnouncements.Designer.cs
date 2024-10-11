namespace MunicipalServiceApp.Forms
{
    partial class FormEventsAndAnnouncements
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
            this.dtPickerFilter = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.lblEvents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtPickerFilter
            // 
            this.dtPickerFilter.Location = new System.Drawing.Point(219, 35);
            this.dtPickerFilter.Name = "dtPickerFilter";
            this.dtPickerFilter.Size = new System.Drawing.Size(222, 22);
            this.dtPickerFilter.TabIndex = 1;
            this.dtPickerFilter.Value = new System.DateTime(2024, 9, 30, 20, 27, 43, 0);
            this.dtPickerFilter.ValueChanged += new System.EventHandler(this.dtPickerFilter_ValueChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(12, 33);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(177, 24);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.Text = "Filter by Category";
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(484, 33);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(88, 24);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(598, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelEvents
            // 
            this.panelEvents.AutoScroll = true;
            this.panelEvents.Location = new System.Drawing.Point(12, 109);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(674, 256);
            this.panelEvents.TabIndex = 6;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(23, 77);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(91, 29);
            this.lblEvents.TabIndex = 7;
            this.lblEvents.Text = "Events";
            // 
            // FormEventsAndAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 484);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dtPickerFilter);
            this.Name = "FormEventsAndAnnouncements";
            this.Text = "Local Events and Announcements";
            this.Load += new System.EventHandler(this.FormEventsAndAnnouncements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtPickerFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.Label lblEvents;
    }
}