
using EMRS.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace EMRS.Library
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IApplyToDrugStock”。
    [ServiceContract]
    public interface IApplyToDrugStock
    {
        /// <summary>
        /// 根据药房代码得到选择药品的列表
        /// </summary>
        /// <param name="stockId">药房代码</param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<ChooseDrugViewModel> GetChooseDrugListByStorage(string stockId);


        /// <summary>
        /// 根据药品代码得到规格
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code);

        /// <summary>
        /// 根据库房代码和药品代码得到规格
        /// </summary>
        /// <param name="stockId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<ChooseDrugSizeViewModel> GetChooseDrugSize(string stockId,string code);

        /// <summary>
        /// 根据库存自动生成药品列表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<CreateDrugListViewModel> GetAutoCreateDrugList(string code);

        /// <summary>
        /// 提交申请
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [OperationContract]
        ResultObj InsertDrugApplication(List<CreateDrugListViewModel> list, string applicantStorage, string provideStorage);

        /// <summary>
        /// 获取药品详细信息
        /// </summary>
        /// <param name="stockId">库房代码</param>
        /// <param name="code">药品代码</param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<DrugStockDetailViewModel> GetDrugDetailList(string stockId, string code);

        /// <summary>
        /// 盘点
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        [OperationContract]
        ResultObjList<DrugCheckViewModel> GetDrugCheck(string storage);

        /// <summary>
        /// 处方出给患者西药
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="patientId">患者ID</param>
        /// <param name="storage">二级库</param>
        /// <param name="orderBy">开方科室</param>
        /// <param name="enterBy">操作人</param>
        /// <returns>出给患者主键</returns>
        [OperationContract]
        ResultObj<PrescMasterIndex> ReduceDrugStock(List<InpChargeItemViewModel> modelList, string patientId, string storage, string orderBy, string enterBy);

        /// <summary>
        /// 处方出给患者的反向处理
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="prescDate">出给患者主键</param>
        /// <param name="prescNo">出给患者主键</param>
        /// <param name="storage">二级库</param>
        /// <returns></returns>
        [OperationContract]
        ResultObj BackReduceDrugStock(List<InpChargeItemViewModel> modelList, DateTime prescDate, int prescNo, string storage);

        /// <summary>
        /// 目前做退费处理 实际上和药柜的“处方录入”功能完全相同
        /// </summary>
        /// <param name="modelList">西药列表</param>
        /// <param name="patientId">患者ID</param>
        /// <param name="storage">二级库</param>
        /// <param name="orderBy">开方科室</param>
        /// <param name="enterBy">操作人</param>
        /// <returns></returns>
        [OperationContract]
        ResultObj Refund(List<InpChargeItemViewModel> modelList, string patientId, string storage, string orderBy, string enterBy);



    }
}
