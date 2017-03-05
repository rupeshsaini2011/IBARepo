using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAEntities
{
    public class AEntity
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Institute { get; set; }

        public string Village { get; set; }
        public string Tehsil { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }

        public string OtherDetails { get; set; }

        public double CurrentValue { get; set; }
        public bool OwnName { get; set; }
        public string OwnerName { get; set; }
        public string OwnerRelation { get; set; }

        public Constants.HowAcquired HowAcquired { get; set; }
        public string AcquiredFrom { get; set; }
        public DateTime AcquiredDate { get; set; }

        public string FundingSource { get; set; }

        public double AnnualIncome { get; set; }

        public string Remarks { get; set; }




    }
}
