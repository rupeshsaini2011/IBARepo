using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAEntities
{
    public class YearSubmissions
    {
        public int Year { get; set; }
        public SubmissionEntity submission { get; set; }
        public bool submitted { get; set; }

        public DateTime SubmissionDate { get; set; }
    }
}
