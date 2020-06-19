using EMRS.Domain;
using EMRS.Repositories;
using System;

namespace EMRS_Repository
{
    public class PrescMasterRepository : GenericRepository<DRUG_PRESC_MASTER>, IPrescMasterRepository
    {
        public int GetPrescMasterIndex()
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                string sql = "SELECT presc_no_seq.NEXTVAL FROM DUAL";
                var item = db.Ado.GetScalar(sql);
                if (item == null)
                {
                    return 0;
                }
                return Convert.ToInt32(item);
            }

        }
    }
}
