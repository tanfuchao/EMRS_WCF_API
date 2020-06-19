using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public interface IDrugPriceRepository : IRepository<DRUG_PRICE_LIST>
    {
        IEnumerable<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code);

        IEnumerable<CreateDrugListViewModel> GetAutoCreateDrugList(string code);
    }
}
