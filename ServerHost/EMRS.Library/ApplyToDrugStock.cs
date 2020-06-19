using EMRS.Model;
using EMRS.Services;
using System;
using System.Collections.Generic;

namespace EMRS.Library
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“ApplyToDrugStock”。
    public class ApplyToDrugStock : IApplyToDrugStock
    {
        private readonly IDrugStockService drugStockService = new DrugStockService();
        private readonly IDrugPriceService drugPriceService = new DrugPriceService();
        private readonly IDrugApplicationService drugApplicationService = new DrugApplicationService();
        private readonly IDrugDictService drugDictService = new DrugDictService();


        /// <summary>
        /// 根据药房代码得到选择药品的列表
        /// </summary>
        /// <param name="stockId">药房代码</param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugViewModel> GetChooseDrugListByStorage(string stockId)
        {
            var result = drugStockService.GetChooseDrugListByStorage(stockId);
            return result;
        }

        /// <summary>
        /// 根据药品代码得到规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code)
        {
            var result = drugPriceService.GetChooseDrugSizeByCode(code);
            return result;
        }

        /// <summary>
        /// 根据库房代码和药品代码得到规格
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSize(string stockId, string code)
        {
            var result = drugPriceService.GetChooseDrugSizeByCode(stockId, code);
            return result;
        }

        /// <summary>
        /// 根据库存自动生成药品列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ResultObjList<CreateDrugListViewModel> GetAutoCreateDrugList(string code)
        {
            var result = drugPriceService.GetAutoCreateDrugList(code);
            return result;
        }

        /// <summary>
        /// 提交申请
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public ResultObj InsertDrugApplication(List<CreateDrugListViewModel> list, string applicantStorage, string provideStorage)
        {
            var result = drugApplicationService.InsertDrugApplication(list, applicantStorage, provideStorage);
            return result;
        }

        /// <summary>
        /// 获取药品详细信息
        /// </summary>
        /// <param name="stockId">库房代码</param>
        /// <param name="code">药品代码</param>
        /// <returns></returns>
        public ResultObjList<DrugStockDetailViewModel> GetDrugDetailList(string stockId, string code)
        {
            var result = drugDictService.GetDrugDetail(stockId, code);
            return result;
        }

        /// <summary>
        /// 盘点
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public ResultObjList<DrugCheckViewModel> GetDrugCheck(string storage)
        {
            var list = drugStockService.GetDrugCheck(storage);
            return list;
        }

        /// <summary>
        /// 处方出给患者西药
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="patientId">患者ID</param>
        /// <param name="storage">二级库</param>
        /// <param name="orderBy">开方科室</param>
        /// <param name="enterBy">操作人</param>
        /// <returns>出给患者主键</returns>
        public ResultObj<PrescMasterIndex> ReduceDrugStock(List<InpChargeItemViewModel> modelList, string patientId, string storage, string orderBy, string enterBy)
        {
            var result = drugStockService.ReduceDrugStock(modelList, patientId, storage, orderBy, enterBy);
            return result;
        }

        /// <summary>
        /// 处方出给患者的反向处理
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="prescDate">出给患者主键</param>
        /// <param name="prescNo">出给患者主键</param>
        /// <param name="storage">二级库</param>
        /// <returns></returns>
        public ResultObj BackReduceDrugStock(List<InpChargeItemViewModel> modelList, DateTime prescDate, int prescNo, string storage)
        {
            var result = drugStockService.BackReduceDrugStock(modelList, prescDate, prescNo, storage);
            return result;
        }

        /// <summary>
        /// 目前做退费处理 实际上和药柜的“处方录入”功能完全相同
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="patientId">患者ID</param>
        /// <param name="storage">二级库</param>
        /// <param name="orderBy">开方科室</param>
        /// <param name="enterBy">操作人</param>
        /// <returns></returns>
        public ResultObj Refund(List<InpChargeItemViewModel> modelList, string patientId, string storage, string orderBy, string enterBy)
        {
            throw new NotImplementedException();
        }
    }
}
