using EMRS.Domain;
using EMRS.Repositories;

namespace EMRS_Repository
{
    public class StockDictRepository : GenericRepository<DRUG_SUB_STORAGE_DICT>, IStockDictRepository
    {
        public string GetStockName(string sotckId) 
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                string name = db.Queryable<DRUG_SUB_STORAGE_DICT>()
                    .Where(m => m.STORAGE_CODE == sotckId)
                    .Select(m => m.SUB_STORAGE)
                    .First();
                return name;
            }
        }
    }
}
