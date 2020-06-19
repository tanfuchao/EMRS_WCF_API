using EMRS.Domain;
using EMRS.Repositories;

namespace EMRS_Repository
{
    public interface IDrugNameRepository : IRepository<DRUG_NAME_DICT>
    {
        string GetDrugName(string code);
    }
}
