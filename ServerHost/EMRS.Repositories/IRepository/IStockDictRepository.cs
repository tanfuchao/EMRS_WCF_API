using EMRS.Domain;
using EMRS.Repositories;

namespace EMRS_Repository
{
    public interface IStockDictRepository : IRepository<DRUG_SUB_STORAGE_DICT>
    {
        string GetStockName(string sotckId);
    }
}
