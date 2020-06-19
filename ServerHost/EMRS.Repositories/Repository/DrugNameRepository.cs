using EMRS.Domain;
using EMRS.Model;
using EMRS.Repositories;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public class DrugNameRepository : GenericRepository<DRUG_NAME_DICT>, IDrugNameRepository
    {

        public string GetDrugName(string code)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var name = db.Queryable<DRUG_NAME_DICT>()
                    .Where(m => m.DRUG_CODE == code)
                    .Select(m => m.DRUG_NAME).First();
                return name;
            }
        }
    }
}
