using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MunicipalServiceApp.Forms
{
    public partial class FormEventsAndAnnouncements : Form
    {
        // Initialize the custom PriorityQueue
        private PriorityQueue<Event, DateTime> eventPriorityQueue = new PriorityQueue<Event, DateTime>();

        // SortedDictionary for organizing events by date
        private SortedDictionary<DateTime, List<Event>> eventsDictionary = new SortedDictionary<DateTime, List<Event>>();
        
        //Hashset for categories
        HashSet<string> eventCategories = new HashSet<string> { "Public Meeting", "Maintenance", "Community Event", "Garbage Collection" };

        public FormEventsAndAnnouncements()
        {
            InitializeComponent();
        }

        private void FormEventsAndAnnouncements_Load(object sender, EventArgs e)
        {
            //set custom date picker text initially
            SetDateTimePickerToNoValue();

            LoadEvents();
            LoadCategories();
        }

        private void LoadEvents()
        {
            // Clear existing events to prevent duplication on reload
            eventPriorityQueue = new PriorityQueue<Event, DateTime>();
            eventsDictionary.Clear();

            // Sample data to populate the priority queue and sorted dictionary
            var sampleEvents = new List<Event>
            {
                new Event(
                    new DateTime(2024, 11, 5),
                    "Town Hall Meeting",
                    "Public Meeting",
                    "Join us for the annual town hall meeting to discuss community issues and upcoming projects.",
                    Image.FromFile(Path.Combine("C:\\Users\\raven\\OneDrive - ADvTECH Ltd\\Modules\\github-repos\\prog7312-part-1-ST10066757", "Resources", "townhall.png"))
                ),
                new Event(
                    new DateTime(2024, 11, 10),
                    "Park Maintenance",
                    "Maintenance",
                    "Scheduled maintenance for Central Park. Expect limited access and maintenance activities.",
                    Image.FromFile(Path.Combine("C:\\Users\\raven\\OneDrive - ADvTECH Ltd\\Modules\\github-repos\\prog7312-part-1-ST10066757", "Resources", "parkMaintenance.png"))
                ),
                new Event(
                    new DateTime(2024, 11, 15),
                    "Community Cleanup Day",
                    "Community Event",
                    "Volunteer for the community cleanup day to help keep our neighborhoods clean and green.",
                    Image.FromFile(Path.Combine("C:\\Users\\raven\\OneDrive - ADvTECH Ltd\\Modules\\github-repos\\prog7312-part-1-ST10066757", "Resources", "communityCleanUp.png"))
                ),
                new Event(
                    new DateTime(2024, 11, 20),
                    "Weekly Garbage Collection",
                    "Garbage Collection",
                    "Reminder: Garbage collection will occur every Monday and Thursday.",
                    Image.FromFile(Path.Combine("C:\\Users\\raven\\OneDrive - ADvTECH Ltd\\Modules\\github-repos\\prog7312-part-1-ST10066757", "Resources", "garbageCollection.png"))
                ),
                new Event(
                    new DateTime(2024, 12, 1),
                    "City Council Meeting",
                    "Public Meeting",
                    "The city council will discuss the new budget allocations for the upcoming year, focusing on infrastructure and community services.",
                    Image.FromFile(Path.Combine("C:\\Users\\raven\\OneDrive - ADvTECH Ltd\\Modules\\github-repos\\prog7312-part-1-ST10066757", "Resources", "cityCouncil.png"))
                )
            };

            foreach (var evt in sampleEvents)
            {
                // Enqueue into PriorityQueue
                eventPriorityQueue.Enqueue(evt, evt.Date);

                // Add to SortedDictionary
                AddEventToSortedDictionary(evt);
            }

            // Populate the display
            DisplayAllEvents();
        }

        private void AddEventToSortedDictionary(Event evt)
        {
            if (eventsDictionary.ContainsKey(evt.Date))
            {
                eventsDictionary[evt.Date].Add(evt);
            }
            else
            {
                eventsDictionary[evt.Date] = new List<Event> { evt };
            }
        }

        private void DisplayAllEvents()
        {
            panelEvents.Controls.Clear(); // Clear existing controls

            int yOffset = 10; // Start Y position
            int panelHeight = 120; // Fixed height for each event panel (adjust as needed)
            int panelWidth = panelEvents.Width - 30; // Adjust width based on panel size
            int spacing = 10; // Spacing between event panels

            // Create a clone of the PriorityQueue to avoid modifying the original
            var tempQueue = eventPriorityQueue.Clone();

            while (tempQueue.Count > 0)
            {
                var currentEvent = tempQueue.Dequeue();

                // Create a Panel for each event
                Panel eventPanel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, yOffset),
                    Tag = currentEvent // Store the event object for potential future use
                };

                // Create PictureBox for the event image
                PictureBox eventPictureBox = new PictureBox
                {
                    Image = currentEvent.EventImage,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 100,
                    Location = new Point(10, 10)
                };

                // Create Label for the event name
                Label nameLabel = new Label
                {
                    Text = currentEvent.Name,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(120, 10),
                    AutoSize = true
                };

                // Create Label for the event date
                Label dateLabel = new Label
                {
                    Text = currentEvent.Date.ToString("MMMM dd, yyyy"),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(120, 35),
                    AutoSize = true
                };

                // Create RichTextBox for the event description
                RichTextBox descriptionBox = new RichTextBox
                {
                    Text = currentEvent.Description,
                    ReadOnly = true,
                    Location = new Point(120, 60),
                    Size = new Size(panelWidth - 130, 80),
                    BackColor = eventPanel.BackColor,
                    BorderStyle = BorderStyle.None
                };

                // Add controls to the event panel
                eventPanel.Controls.Add(eventPictureBox);
                eventPanel.Controls.Add(nameLabel);
                eventPanel.Controls.Add(dateLabel);
                eventPanel.Controls.Add(descriptionBox);

                // Add the event panel to the main panelEvents
                panelEvents.Controls.Add(eventPanel);

                // Update yOffset for the next event panel
                yOffset += panelHeight + spacing;
            }

            // If no events are present, display a message
            if (panelEvents.Controls.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "No events available.",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                panelEvents.Controls.Add(emptyLabel);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? selectedDate = null;

            // Only filter by date if the user has selected a valid date
            if (dtPickerFilter.Format != DateTimePickerFormat.Custom)
            {
                selectedDate = dtPickerFilter.Value.Date;
            }

            string selectedCategory = cbFilter.SelectedItem?.ToString();

            // Call filter method with the selected date and category
            FilterEvents(selectedDate, selectedCategory);
        }

        private void FilterEvents(DateTime? selectedDate, string category)
        {
            panelEvents.Controls.Clear(); // Clear existing controls

            int yOffset = 10; // Start Y position for the first panel
            int panelHeight = 150; // Fixed height for each event panel (adjust as needed)
            int panelWidth = panelEvents.Width - 40; // Adjust width based on panel size
            int spacing = 10; // Spacing between event panels

            bool eventsFound = false;

            // Create a clone of the PriorityQueue to iterate without modifying the original
            var tempQueue = eventPriorityQueue.Clone();

            while (tempQueue.Count > 0)
            {
                var currentEvent = tempQueue.Dequeue();

                bool matchesDate = selectedDate == null || currentEvent.Date.Date == selectedDate.Value.Date;
                bool matchesCategory = string.IsNullOrEmpty(category) || currentEvent.Category.Equals(category, StringComparison.OrdinalIgnoreCase);

                // If both date and category match, display the event
                if (matchesDate && matchesCategory)
                {
                    eventsFound = true;

                    // Create a Panel for each event
                    Panel eventPanel = new Panel
                    {
                        Width = panelWidth,
                        Height = panelHeight,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(10, yOffset),
                        Tag = currentEvent // Store the event object for potential future use
                    };

                    // Create PictureBox for the event image
                    PictureBox eventPictureBox = new PictureBox
                    {
                        Image = currentEvent.EventImage,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 100,
                        Location = new Point(10, 10)
                    };

                    // Create Label for the event name
                    Label nameLabel = new Label
                    {
                        Text = currentEvent.Name,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        Location = new Point(120, 10),
                        AutoSize = true
                    };

                    // Create Label for the event date
                    Label dateLabel = new Label
                    {
                        Text = currentEvent.Date.ToString("MMMM dd, yyyy"),
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Location = new Point(120, 35),
                        AutoSize = true
                    };

                    // Create RichTextBox for the event description
                    RichTextBox descriptionBox = new RichTextBox
                    {
                        Text = currentEvent.Description,
                        ReadOnly = true,
                        Location = new Point(120, 60),
                        Size = new Size(panelWidth - 130, 80),
                        BackColor = eventPanel.BackColor,
                        BorderStyle = BorderStyle.None
                    };

                    // Add controls to the event panel
                    eventPanel.Controls.Add(eventPictureBox);
                    eventPanel.Controls.Add(nameLabel);
                    eventPanel.Controls.Add(dateLabel);
                    eventPanel.Controls.Add(descriptionBox);

                    // Add the event panel to the main panelEvents
                    panelEvents.Controls.Add(eventPanel);

                    // Update yOffset for the next event panel
                    yOffset += panelHeight + spacing;
                }
            }

            // If no events were found, display a message
            if (!eventsFound)
            {
                Label emptyLabel = new Label
                {
                    Text = "No events found for the selected criteria.",
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };

                panelEvents.Controls.Add(emptyLabel);
            }
        }


        private void LoadCategories()
        {
            cbFilter.Items.Clear();
            foreach (var category in eventCategories)
            {
                cbFilter.Items.Add(category);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset DateTimePicker to have no value (show placeholder)
            SetDateTimePickerToNoValue();

            // Clear the ComboBox selection
            cbFilter.SelectedIndex = -1;

            // Reload and display all events
            DisplayAllEvents();
        }

        private void SetDateTimePickerToNoValue()
        {
            dtPickerFilter.Format = DateTimePickerFormat.Custom;
            dtPickerFilter.CustomFormat = " "; // Show this as the placeholder text
        }

        private void dtPickerFilter_ValueChanged(object sender, EventArgs e)
        {
            // When the user selects a date, reset the format to show the selected date
            dtPickerFilter.Format = DateTimePickerFormat.Short;
        }
    }
}
