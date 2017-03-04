using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAEntities
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string  firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string  passWord { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public int BankId { get; set; }
        public Constants.StaffType SType { get; set; }


    }
}
