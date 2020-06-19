using EMRS.Domain;
using EMRS.Model;
using System.Collections.Generic;

namespace EMRS.Services
{
    public interface IDrugPriceService : IService<DRUG_PRICE_LIST>
    {
        /// <summary>
        /// 根据药品代码得到规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code);

        /// <summary>
        /// 根据库房代码和药品代码得到规格
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string stockId, string code);

        /// <summary>
        /// 根据库存自动生成药品列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        ResultObjList<CreateDrugListViewModel> GetAutoCreateDrugList(string code);
    }
}
