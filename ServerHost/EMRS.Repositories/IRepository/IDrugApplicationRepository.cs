using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public interface IDrugApplicationRepository : IRepository<DRUG_PROVIDE_APPLICATION>
    {
        bool InsertDrugApplication(List<DRUG_PROVIDE_APPLICATION> list,string applicantStorage, string provideStorage);
    }
}
