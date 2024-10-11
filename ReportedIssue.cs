using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class ReportedIssue
    {
        #region Variables
        //variables to save an issues form
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        #endregion

        #region Constructor
        public ReportedIssue(string location, string category, string description, string filePath)
        {
            Location = location;
            Category = category;
            Description = description;
            FilePath = filePath;
        }
        #endregion
    }
}
