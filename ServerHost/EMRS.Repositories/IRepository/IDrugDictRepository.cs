using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public interface IDrugDictRepository : IRepository<DRUG_DICT>
    {
        IEnumerable<DrugStockDetailViewModel> GetDrugDetail(string storage, string code);
    }
}
