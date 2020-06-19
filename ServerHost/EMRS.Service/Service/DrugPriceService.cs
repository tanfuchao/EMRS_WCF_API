using EMRS.Domain;
using EMRS.Model;
using EMRS_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace EMRS.Services
{
    public class DrugPriceService : GenericService<DRUG_PRICE_LIST>, IDrugPriceService
    {
        private readonly IDrugPriceRepository _repository = new DrugPriceRepository();
        private readonly IDrugStockRepository _stockRepository = new DrugStockRepository();


        /// <summary>
        /// 根据药品代码得到规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code)
        {
            ResultObjList<ChooseDrugSizeViewModel> result = new ResultObjList<ChooseDrugSizeViewModel>();
            List<ChooseDrugSizeViewModel> list = _repository.GetChooseDrugSizeByCode(code).ToList();
            result.isSuccess = true;
            result.code = (int)HttpStatusCode.OK;
            result.data = list;
            return result;
        }

        /// <summary>
        /// 根据库房代码和药品代码得到规格
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string stockId, string code)
        {
            ResultObjList<ChooseDrugSizeViewModel> result = new ResultObjList<ChooseDrugSizeViewModel>();
            bool flag = _stockRepository.ExistDrug(stockId, code);
            if (!flag) 
            {
                result.isSuccess = false;
                result.code = (int)HttpStatusCode.NotFound;
                result.massage = "药品不存在";
                return result;
            }
            List<ChooseDrugSizeViewModel> list = _repository.GetChooseDrugSizeByCode(code).ToList();
            result.isSuccess = true;
            result.code = (int)HttpStatusCode.OK;
            result.data = list;
            return result;
        }

        /// <summary>
        /// 根据库存自动生成药品列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<CreateDrugListViewModel> GetAutoCreateDrugList(string code)
        {
            ResultObjList<CreateDrugListViewModel> result = new ResultObjList<CreateDrugListViewModel>();
            List<CreateDrugListViewModel> list = _repository.GetAutoCreateDrugList(code).ToList();
            result.isSuccess = true;
            result.code = (int)HttpStatusCode.OK;
            result.data = list;
            return result;
        }
    }
}
