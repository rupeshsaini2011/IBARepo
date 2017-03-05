using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAEntities
{
    public class SubmissionEntity
    {
        public int SubmissionId { get; set; }
        public UserEntity SubmittedBy { get; set; }
        public int SubmittedById { get; set; }
        public int SubmissionYear { get; set; }
        public DateTime SubmissionDate { get; set; }

        public List<string> SubmittedForms { get; set; }


    }
}
