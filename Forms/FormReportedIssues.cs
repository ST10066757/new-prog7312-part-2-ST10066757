using Microsoft.Toolkit.Uwp.Notifications;
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
using System.Xml;

namespace MunicipalServiceApp.Forms
{
    public partial class FormReportedIssues : Form
    {
        #region Declarations
        // Declare the list to store reported issues
        private List<ReportedIssue> issuesList = new List<ReportedIssue>();

        // Boolean flags to track completion of each field
        private bool isLocationFilled = false;
        private bool isCategoryFilled = false;
        private bool isDescriptionFilled = false;
        private bool isFilePathFilled = false;

        // List of messages to send notifications
        List<string> notificationMessages = new List<string>()
        {
            "Check for water leaks in your area.",
            "Have you checked upcoming community events?",
            "Don't forget to report any issues you spot around town.",
            "Stay updated on road closures and maintenance work."
        };

        // Timer to check for inactivity
        System.Windows.Forms.Timer inactivityTimer;
        DateTime lastActivityTime;
        #endregion

        #region Constructor
        public FormReportedIssues()
        {
            InitializeComponent();
        }
        #endregion

        #region Method to load random theme
        //loads the random theme generated when a user clicks on a form
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColour.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColour.SecondaryColor;
                }
            }
            lblFilePath.ForeColor = ThemeColour.SecondaryColor;
            lblProgress.ForeColor = ThemeColour.SecondaryColor;
        }
        #endregion

        #region Attach File btn click event
        //opens a box for users to select a file they wish to upload
        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblFilePath.Text = openFileDialog.FileName;
                lblFilePath.Visible = true;
                isFilePathFilled = true;
                UpdateProgressBar();
            }
        }
        #endregion

        #region Submit Issue btn click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string location = txtLocation.Text;
            string category = cbCategory.SelectedItem != null ? cbCategory.SelectedItem.ToString() : string.Empty;
            string description = rtbDescription.Text;
            string filePath = lblFilePath.Text;

            // Validate inputs (basic validation example)
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate file selection
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select a file before submitting.","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a report issue object and store it in a list (or any data structure)
            ReportedIssue newIssue = new ReportedIssue(location, category, description, filePath);
            issuesList.Add(newIssue);

            // Save the issue list to a text file
            SaveIssuesToFile("issues.txt");

            UserInteracted();

            // Clear form fields after submission
            txtLocation.Clear();
            cbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            lblFilePath.Text = string.Empty;
            progressBar1.Value = 0;

            // Reset boolean flags
            isLocationFilled = false;
            isCategoryFilled = false;
            isDescriptionFilled = false;
            isFilePathFilled = false;

            //reset the visibility of a label or update progress
            lblProgress.Visible = false; //label visibility reset
            SetHintText(txtLocation, "Enter location...");
            SetHintText(rtbDescription, "Enter issue description...");

            MessageBox.Show("Issue has been successfully created!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Save Issue to txt file method
        // Method to save the issue list to a text file
        private void SaveIssuesToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var issue in issuesList)
                {
                    writer.WriteLine($"{issue.Location}|{issue.Category}|{issue.Description}|{issue.FilePath}");
                }
            }
        }
        #endregion

        #region Load Issues from txt file method
        // Method to load the issue list from a text file
        private void LoadIssuesFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            ReportedIssue issue = new ReportedIssue(parts[0], parts[1], parts[2], parts[3]);
                            issuesList.Add(issue);
                        }
                    }
                }
            }
        }
        #endregion

        #region Set and Remove Hint Text methods 
        //methods that set and remove the text hint from textboxes and rich text boxes
        private void SetHintText(Control control, string hint)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                control.Text = hint;
                control.ForeColor = Color.Gray;
            }
        }

        private void RemoveHintText(Control control, string hint)
        {
            if (control.Text == hint)
            {
                control.Text = "";
                control.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Update Progress Bar dynamically method
        //used to update the progress bar when a user starts filling out the form
        private void UpdateProgressBar()
        {
            int progress = 0;

            if (isLocationFilled) progress += 25;
            if (isCategoryFilled) progress += 25;
            if (isDescriptionFilled) progress += 25;
            if (isFilePathFilled) progress += 25;

            progressBar1.Value = progress;

            // Make the TextView visible once progress starts
            if (progress > 0)
            {
                lblProgress.Text = "";
                lblProgress.Visible = true;
            }

            // Update the TextView based on progress
            if (progress == 50)
            {
                lblProgress.Text = "You are halfway there :)";
            }
            else if (progress == 100)
            {
                lblProgress.Text = "Form complete, click submit to post the issue!";
            }
            else
            {
                // Clear or set default text for other progress values if needed
                lblProgress.Text = "";
            }
        }
        #endregion

        #region Enter and Leave events
        //sets and removes text hint when a user clicks on the text box or rich text box
        private void txtLocation_Enter(object sender, EventArgs e)
        {
            RemoveHintText(txtLocation, "Enter location...");
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            SetHintText(txtLocation, "Enter location...");
            isLocationFilled = !string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text != "Enter location...";
            UpdateProgressBar();
        }

        private void rtbDescription_Enter(object sender, EventArgs e)
        {
            RemoveHintText(rtbDescription, "Enter issue description...");
        }

        private void rtbDescription_Leave(object sender, EventArgs e)
        {
            SetHintText(rtbDescription, "Enter issue description...");
            isDescriptionFilled = !string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text != "Enter issue description...";
            UpdateProgressBar();
        }
        #endregion

        #region comboBox index event
        // used to update the progress bar if the combo box index is not -1
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            isCategoryFilled = cbCategory.SelectedIndex != -1;
            UpdateProgressBar();
        }
        #endregion

        #region Form Load event
        //used to set hints for texts, load theme and populate the list so that data isn't lost
        private void FormReportedIssues_Load(object sender, EventArgs e)
        {
            // Set initial hints
            SetHintText(txtLocation, "Enter location...");
            SetHintText(rtbDescription, "Enter issue description...");
            lblFilePath.Text = "";
            LoadTheme();
            LoadIssuesFromFile("issues.txt");

            // Set the last activity time to now
            lastActivityTime = DateTime.Now;

            // Set up a timer to check for inactivity every minute
            inactivityTimer = new System.Windows.Forms.Timer();
            inactivityTimer.Interval = 60000; // 1 minute
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer.Start();
        }
        #endregion

        #region User Interacted method

        // Method to Track user interactions
        private void UserInteracted()
        {
            lastActivityTime = DateTime.Now;
        }
        #endregion

        #region Send Random Notification method
        // Send a random notification
        //Reference: https://learn.microsoft.com/en-us/windows/apps/design/shell/tiles-and-notifications/send-local-toast?tabs=uwp
        private void SendRandomNotification()
        {
            // Pick a random message from the list
            Random random = new Random();
            int index = random.Next(notificationMessages.Count);
            string message = notificationMessages[index];

            // Create the toast notification content
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Municipal Services Alert")
                .AddText(message)
                .Show();  // This shows the toast

            // Log to check if the method was called
            Console.WriteLine("Notification sent: " + message);

            // Reset last activity time
            lastActivityTime = DateTime.Now;
        }
        #endregion

        #region Inactivity Timer Event
        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            // Check if the app has been inactive for 10 min (600 seconds)
            if ((DateTime.Now - lastActivityTime).TotalSeconds > 600)
            {
                // Trigger a random notification if the user has been inactive for 10 min
                SendRandomNotification();
            }
        }
        #endregion
    }
}
