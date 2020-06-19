using EMRS.Domain;
using EMRS.Repositories;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public class DrugApplicationRepository : GenericRepository<DRUG_PROVIDE_APPLICATION>, IDrugApplicationRepository
    {
        public bool InsertDrugApplication(List<DRUG_PROVIDE_APPLICATION> list,string applicantStorage,string provideStorage)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                int maxItem = db.Queryable<DRUG_PROVIDE_APPLICATION>()
                    .Where(d=>d.APPLICANT_STORAGE== applicantStorage)
                    .Max(d => d.ITEM_NO);
                try
                {
                    db.Ado.UseTran(() =>
                    {
                        foreach (DRUG_PROVIDE_APPLICATION item in list)
                        {
                            if (item == null) 
                            {
                                continue;
                            }
                            maxItem++;
                            item.ITEM_NO = maxItem;
                            item.APPLICANT_STORAGE = applicantStorage;
                            item.PROVIDE_STORAGE = provideStorage;
                            db.Insertable(item).ExecuteCommand();
                        }
                    });
                    return true;
                }
                catch (System.Exception ex)
                {
                    return false;
                    throw ex;
                }
            }
        }
    }
}
