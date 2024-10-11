using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class Form1 : Form
    {
        #region Declarations
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        #endregion

        #region Constructor
        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.MinimumSize = new Size(800, 500);
        }
        #endregion

        #region Select Theme Method
        //Method to randomly select a color when a user opens a form
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColour.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColour.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColour.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        #endregion

        #region Activate Theme Method
        //Method to activate the random theme
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColour.ChangeColorBrightness(color, -0.3);
                    ThemeColour.PrimaryColor = color;
                    ThemeColour.SecondaryColor = ThemeColour.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        #endregion

        #region Disable Theme Method
        //Method to disable the random theme generated when a user goes back to Main Menu
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 0, 128);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #endregion

        #region Open Form as child
        //Method opens a form in the open Panel to maintain the menu buttons 
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        #endregion

        #region Open ReportIssue Form event 
        //Opens the Report Issue Form in the panel
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportedIssues(), sender);
        }
        #endregion

        #region Close Application
        //Event to close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Event To Close Child Form
        //Closes the child form and returns to the start up screen
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null) 
            activeForm.Close();
            Reset();
        }
        #endregion

        #region Reset Theme Method
        //Reset the Theme to the start up theme
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Main Menu";
            panelTitle.BackColor = Color.FromArgb(100, 149, 237);
            panelLogo.BackColor = Color.FromArgb(25, 25, 112);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        #endregion

        #region Open Local Events and Announcements Form
        //Opens the local events and announcements form in the panel
        private void btnLocalEvent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEventsAndAnnouncements(), sender);
        }
        #endregion
    }
}
