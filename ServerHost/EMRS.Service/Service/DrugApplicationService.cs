using EMRS.Mapper;
using EMRS.Domain;
using EMRS.Model;
using EMRS_Repository;
using System.Collections.Generic;
using System.Net;

namespace EMRS.Services
{
    public class DrugApplicationService : GenericService<DRUG_PROVIDE_APPLICATION>, IDrugApplicationService
    {
        private readonly IDrugApplicationRepository _repository = new DrugApplicationRepository();

        public ResultObj InsertDrugApplication(List<CreateDrugListViewModel> list, string applicantStorage, string provideStorage) {
            

            ResultObj result = new ResultObj();
            List<DRUG_PROVIDE_APPLICATION> entityList = list.ToEntityList();
            var flag = _repository.InsertDrugApplication(entityList,applicantStorage, provideStorage);
            if (flag)
            {
                result.isSuccess = true;
                result.code = (int)HttpStatusCode.OK;
            }
            else 
            {
                result.isSuccess = false;
                result.code = (int)HttpStatusCode.InternalServerError;
                result.massage = "服务器处理错误";
            }
            return result;
        }
    }
}
