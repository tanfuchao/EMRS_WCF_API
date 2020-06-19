using EMRS.Domain;

namespace EMRS.Services
{
    public interface IDrugNameService : IService<DRUG_NAME_DICT>
    {
        string GetDrugName(string code);
    }
}
