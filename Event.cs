using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class Event : IComparable<Event>
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public Image EventImage { get; set; }

        public Event(DateTime date, string name, string category, string description, Image eventImage)
        {
            Date = date;
            Name = name;
            Category = category;
            Description = description;
            EventImage = eventImage;
        }

        public int CompareTo(Event other)
        {
            if (other == null) return 1;
            return this.Date.CompareTo(other.Date);
        }
    }
}
