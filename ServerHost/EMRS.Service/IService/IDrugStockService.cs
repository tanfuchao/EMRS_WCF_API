using EMRS.Domain;
using EMRS.Model;
using System;
using System.Collections.Generic;

namespace EMRS.Services
{
    public interface IDrugStockService : IService<DRUG_STOCK>
    {
        /// <summary>
        /// 根据药房代码得到选择药品的列表
        /// </summary>
        /// <param name="stockId">药房代码</param>
        /// <returns></returns>
        ResultObjList<ChooseDrugViewModel> GetChooseDrugListByStorage(string stockId);

        ResultObjList<DrugCheckViewModel> GetDrugCheck(string storage);

        ResultObj<PrescMasterIndex> ReduceDrugStock(List<InpChargeItemViewModel> modelList, string patientId, string storage, string orderBy, string enterBy);

        ResultObj BackReduceDrugStock(List<InpChargeItemViewModel> modelList, DateTime prescDate, int prescNo, string storage);
    }
}
