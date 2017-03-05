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
            subs = prov.GetSubmissionByUser(userId);

            return subs;
        }

        
       
        public AEntity GetFormAData(int year, int userId)
        {
            DBProvider prov = new DBProvider();
            return prov.GetFormAData(year, userId);


        }

        public BEntity GetFormBData(int year, int userId)
        {
            DBProvider prov = new DBProvider();
           return  prov.GetFormBData(year, userId);

            
        }

        public CEntity GetFormCData(int year, int userId)
        {
            DBProvider prov = new DBProvider();
            return prov.GetFormCData(year, userId);
        }

        public DEntity GetFormDData(int year, int userId)
        {
            DBProvider prov = new DBProvider();
            return prov.GetFormDData(year, userId);
        }




        public void SaveFormA(AEntity aa, int year, int userId)
        {
            DBProvider prov = new DBProvider();
            prov.SaveFormA(aa, year, userId);

        }
        

        public void SaveFormB(BEntity bb, int year, int userId)
        {

            DBProvider prov = new DBProvider();
            prov.SaveFormB(bb, year, userId);
        }

        public void SaveFormC(CEntity cc, int year, int userId)
        {
            DBProvider prov = new DBProvider();
            prov.SaveFormC(cc, year, userId);
        }


        public void SaveFormD(DEntity dd, int year, int userId)
        {
            DBProvider prov = new DBProvider();
            prov.SaveFormD(dd, year, userId);
        }





    }

}
