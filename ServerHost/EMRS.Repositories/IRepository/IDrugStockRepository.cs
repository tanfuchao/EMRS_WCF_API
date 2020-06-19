using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using System.Collections.Generic;
using System;

namespace EMRS_Repository
{
    public interface IDrugStockRepository : IRepository<DRUG_STOCK>
    {
        /// <summary>
        /// 根据库房ID 获取药物列表
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        IEnumerable<ChooseDrugViewModel> GetChooseDrugListByStorage(string storage);

        /// <summary>
        /// 根据（药房ID和DrugCode） 判断药房是否存在 
        /// </summary>
        /// <param name="sotckId"></param>
        /// <param name="drugCode"></param>
        /// <returns></returns>
        bool ExistDrug(string sotckId, string drugCode);

        /// <summary>
        /// 盘点
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        IEnumerable<DrugCheckViewModel> GetDrugCheck(string storage);

        bool ReduceDrugStock(List<DRUG_STOCK> drugModelList, DRUG_PRESC_MASTER masterModel, List<DRUG_PRESC_DETAIL> detailModelList);

        bool BackReduceDrugStock(List<DRUG_STOCK> drugModelList, DateTime date,int no,bool detail,bool master);
    }
}
