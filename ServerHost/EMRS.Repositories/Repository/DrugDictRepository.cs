using EMRS.Domain;
using EMRS.Model;
using EMRS.Repositories;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public class DrugDictRepository : GenericRepository<DRUG_DICT>, IDrugDictRepository
    {

        public IEnumerable<DrugStockDetailViewModel> GetDrugDetail(string storage,string code)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                var list =db.Queryable<DRUG_STOCK, DRUG_DICT>((s, d) => s.DRUG_CODE == d.DRUG_CODE && s.DRUG_SPEC == d.DRUG_SPEC)
                    .Where((s, d) => s.SUPPLY_INDICATOR == 1)
                    .Where((s, d) => s.STORAGE == storage)
                    .Where((s, d) => s.DRUG_CODE == code)
                    .Select((s,d)=> new DrugStockDetailViewModel 
                    {
                        DRUG_CODE = s.DRUG_CODE,
                        STORAGE = s.STORAGE,
                        ADMINISTRATION = d.ADMINISTRATION,
                        BATCH_NO = s.BATCH_NO,
                        EXPIRE_DATE = s.EXPIRE_DATE,
                        QUANTITY = s.QUANTITY,
                        SUB_STORAGE = s.SUB_STORAGE,
                        SUPPLY_INDICATOR = s.SUPPLY_INDICATOR,
                        DOSE_PER_UNIT = d.DOSE_PER_UNIT,
                        DRUG_SPEC = s.DRUG_SPEC,
                        FIRM_ID = s.FIRM_ID,
                        DOSE_UNITS = d.DOSE_UNITS,
                        NOTES = d.NOTES,
                        UNITS = s.UNITS
                    })
                    .ToList();
                return list;
            }
        }
    }
}
