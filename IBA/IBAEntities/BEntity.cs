using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace IBAEntities
{
    public class BEntity
    {
        public int BId { get; set; }

        public int LastYearSharesNo { get; set; }
        public double LastYearSharesValue { get; set; }
        public double LastyearSharesCostofacquisition { get; set; }
        public int CurrentYearSharesNo { get; set; }
        public double CurrentYearSharesValue { get; set; }
        public double CurrentyearSharesCostofacquisition { get; set; }
        public double ThisyearSharesCostofacquisition { get; set; }
        public string SharesFundingSource { get; set; }

        public int LastYearDebenturesNo { get; set; }
        public double LastYearDebenturesValue { get; set; }
        public double LastyearDebenturesCostofacquisition { get; set; }
        public int CurrentYearDebenturesNo { get; set; }
        public double CurrentYearDebenturesValue { get; set; }
        public double CurrentyearDebenturesCostofacquisition { get; set; }
        public double ThisyearDebenturesCostofacquisition { get; set; }
        public string DebenturesFundingSource { get; set; }


        public int LastYearUnitsNo { get; set; }
        public double LastYearUnitsValue { get; set; }
        public double LastyearUnitsCostofacquisition { get; set; }
        public int CurrentYearUnitsNo { get; set; }
        public double CurrentYearUnitsValue { get; set; }
        public double CurrentyearUnitsCostofacquisition { get; set; }
        public double ThisyearUnitsCostofacquisition { get; set; }
        public string UnitsFundingSource { get; set; }


        public int LastYearNSCNo { get; set; }
        public double LastYearNSCValue { get; set; }
        public double LastyearNSCCostofacquisition { get; set; }
        public int CurrentYearNSCNo { get; set; }
        public double CurrentYearNSCValue { get; set; }
        public double CurrentyearNSCCostofacquisition { get; set; }
        public double ThisyearNSCCostofacquisition { get; set; }
        public string NSCFundingSource { get; set; }


        public int LastYearNSSNo { get; set; }
        public double LastYearNSSValue { get; set; }
        public double LastyearNSSCostofacquisition { get; set; }
        public int CurrentYearNSSNo { get; set; }
        public double CurrentYearNSSValue { get; set; }
        public double CurrentyearNSSCostofacquisition { get; set; }
        public double ThisyearNSSCostofacquisition { get; set; }
        public string NSSFundingSource { get; set; }


        public int LastYearDepositsNo { get; set; }
        public double LastYearDepositsValue { get; set; }
        public double LastyearDepositsCostofacquisition { get; set; }
        public int CurrentYearDepositsNo { get; set; }
        public double CurrentYearDepositsValue { get; set; }
        public double CurrentyearDepositsCostofacquisition { get; set; }
        public double ThisyearDepositsCostofacquisition { get; set; }
        public string DepositsFundingSource { get; set; }


        public int LastYearBondsNo { get; set; }
        public double LastYearBondsValue { get; set; }
        public double LastyearBondsCostofacquisition { get; set; }
        public int CurrentYearBondsNo { get; set; }
        public double CurrentYearBondsValue { get; set; }
        public double CurrentyearBondsCostofacquisition { get; set; }
        public double ThisyearBondsCostofacquisition { get; set; }
        public string BondsFundingSource { get; set; }



        public int LastYearOthersNo { get; set; }
        public double LastYearOthersValue { get; set; }
        public double LastyearOthersCostofacquisition { get; set; }
        public int CurrentYearOthersNo { get; set; }
        public double CurrentYearOthersValue { get; set; }
        public double CurrentyearOthersCostofacquisition { get; set; }
        public double ThisyearOthersCostofacquisition { get; set; }
        public string OthersFundingSource { get; set; }





    }
}
