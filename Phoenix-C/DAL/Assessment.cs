using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Assessment
    {
        public int AssessmentID { get; set; }
        public int  AssessmentTypeID { get; set; }
        public string AssessmentStatus { get; set; }
        public int ModuleID { get; set; }
        public string DueDate { get; set; }
        public string AssessmentDescription { get; set; }
        
    }
}
