using EMRS.Domain;
using EMRS.Model;

namespace EMRS.Services
{
    public interface IDrugDictService : IService<DRUG_DICT>
    {
        ResultObjList<DrugStockDetailViewModel> GetDrugDetail(string storage, string code);
    }
}
