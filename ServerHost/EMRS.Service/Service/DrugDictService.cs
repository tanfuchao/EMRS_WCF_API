using EMRS.Domain;
using EMRS.Model;
using EMRS_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace EMRS.Services
{
    public class DrugDictService : GenericService<DRUG_DICT>, IDrugDictService
    {
        private readonly IDrugDictRepository _repository = new DrugDictRepository();
        private readonly IDrugNameRepository nameRepository = new DrugNameRepository();

        public ResultObjList<DrugStockDetailViewModel> GetDrugDetail(string storage, string code)
        {
            ResultObjList<DrugStockDetailViewModel> result = new ResultObjList<DrugStockDetailViewModel>();
            string name = nameRepository.GetDrugName(code);
            List<DrugStockDetailViewModel> list = _repository.GetDrugDetail(storage, code).ToList();
            foreach (var item in list)
            {
                item.DRUG_NAME = name;
            }
            result.code = (int)HttpStatusCode.OK;
            result.isSuccess = true;
            result.data = list;
            return result;
        }
    }
}
