using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAEntities
{
    public class Constants
    {
        public enum StaffType { User, Admin};

        public const int DEFAULTVALUE = -1;

        public const string USERSESSIONVAR = "UserSessionVar";
        public const string StartYear = "StartYear";


        public const string FORMA = "Form A";
        public const string FORMB = "Form B";
        public const string FORMC = "Form C";
        public const string FORMD = "Form D";



        public static List<string> AllForms = new List<string>{ FORMA, FORMB, FORMC, FORMD };

        public static string SUBMITSESSIONVAR = "SubmitSessionVar";

        public const string VIEWMODE = "View";

        public static string EDITMODE = "Edit";

        public enum HowAcquired {Gift, Lease, Mortage, Purchase, Otherwise};
    }
}
