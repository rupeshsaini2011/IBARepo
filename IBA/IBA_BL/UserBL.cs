using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBA_DAL;
using IBAEntities;

namespace IBA_BL
{
    public class UserBL
    {
        public UserEntity isAuthenticate(string userName, string password)
        {
           
            DBProvider prov = new DBProvider();

            UserEntity user = prov.GetAuthenticatedUser(userName, password);

           return user;
        }

        public List<SubmissionEntity> GetSubmissions(int userId)
        {
            List<SubmissionEntity> subs = null;
            DBProvider prov = new DBProvider();
            prov.GetSubmissionByUser(userId);

            return subs;
        }

        public void SaveFormA(AEntity aa)
        {
            DBProvider prov = new DBProvider();
            prov.SaveFormA(aa);

        }
    }
}
