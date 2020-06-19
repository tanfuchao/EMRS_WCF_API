using EMRS.Domain;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS.Services
{
    public interface IDrugApplicationService : IService<DRUG_PROVIDE_APPLICATION>
    {
        ResultObj InsertDrugApplication(List<CreateDrugListViewModel> list, string applicantStorage, string provideStorage);
    }
}
