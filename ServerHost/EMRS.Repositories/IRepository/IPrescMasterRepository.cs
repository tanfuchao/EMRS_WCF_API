using EMRS.Domain;
using EMRS.Repositories;

namespace EMRS_Repository
{
    public interface IPrescMasterRepository : IRepository<DRUG_PRESC_MASTER>
    {
        int GetPrescMasterIndex();
    }
}
