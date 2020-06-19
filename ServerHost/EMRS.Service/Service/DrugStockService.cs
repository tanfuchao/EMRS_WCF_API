using EMRS.Domain;
using EMRS.Model;
using EMRS_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;

namespace EMRS.Services
{
    public class DrugStockService : GenericService<DRUG_STOCK>, IDrugStockService
    {
        private readonly IDrugStockRepository _repository = new DrugStockRepository();
        private readonly IPatIndexRepository patIndexRepository = new PatIndexRepository();
        private readonly IPrescMasterRepository masterRepository = new PrescMasterRepository();
        private readonly IPrescDetailRepository detailRepository = new PrescDetailRepository();


        /// <summary>
        /// 根据药房代码得到选择药品的列表
        /// </summary>
        /// <param name="stockId">药房代码</param>
        /// <returns></returns>
        public ResultObjList<ChooseDrugViewModel> GetChooseDrugListByStorage(string stockId)
        {
            List<ChooseDrugViewModel> list = _repository.GetChooseDrugListByStorage(stockId).ToList();
            ResultObjList<ChooseDrugViewModel> result = new ResultObjList<ChooseDrugViewModel>()
            {
                isSuccess = true,
                code = (int)HttpStatusCode.OK,
                data = list
            };
            return result;
        }

        /// <summary>
        /// 盘点
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public ResultObjList<DrugCheckViewModel> GetDrugCheck(string storage)
        {
            List<DrugCheckViewModel> list = _repository.GetDrugCheck(storage).ToList();
            ResultObjList<DrugCheckViewModel> result = new ResultObjList<DrugCheckViewModel>()
            {
                isSuccess = true,
                code = (int)HttpStatusCode.OK,
                data = list
            };
            return result;
        }

        public ResultObj<PrescMasterIndex> ReduceDrugStock(List<InpChargeItemViewModel> modelList, string patientId, string storage,string orderBy,string enterBy)
        {
            ResultObj<PrescMasterIndex> result = new ResultObj<PrescMasterIndex>();
            PrescMasterIndex index = new PrescMasterIndex();
            if (modelList == null) 
            {
                result.code = (int)HttpStatusCode.LengthRequired;
                result.isSuccess = false;
                result.massage = "参数错误！";
                return result;
            }
            if (string.IsNullOrWhiteSpace(patientId))
            {
                result.code = (int)HttpStatusCode.LengthRequired;
                result.isSuccess = false;
                result.massage = "参数错误！";
                return result;
            }
            if (string.IsNullOrWhiteSpace(storage))
            {
                result.code = (int)HttpStatusCode.LengthRequired;
                result.isSuccess = false;
                result.massage = "参数错误！";
                return result;
            }

            //组建传递dal中的药品表List
            List<DRUG_STOCK> drugList = new List<DRUG_STOCK>();
            List<DRUG_PRESC_DETAIL> detailList = new List<DRUG_PRESC_DETAIL>();
            DateTime prescDate = DateTime.Now;
            int prescNo = masterRepository.GetPrescMasterIndex();
            decimal costSum=0;
            decimal paymentSum=0;
            int itemId = 0;
            foreach (var model in modelList)
            {
                if (model == null)
                {
                    result.code = (int)HttpStatusCode.BadRequest;
                    result.isSuccess = false;
                    result.massage = "传递药品列表中有空对象";
                    return result;
                }
                itemId++;
                costSum += model.COSTS;
                paymentSum += model.PAYMENTS;
                //获取药品库存基本信息 
                DRUG_STOCK drugModel = _repository.FindByClause(m => m.DRUG_CODE == model.DRUG_CODE
                && m.STORAGE == storage);

                if (drugModel == null)
                {
                    result.code = (int)HttpStatusCode.BadRequest;
                    result.isSuccess = false;
                    result.massage = "没有在库存中 查询到传递的药品";
                    return result;
                }
                int quantity = drugModel.QUANTITY - model.QUANTITY;
                if (quantity < 0)
                {
                    //判断出给患者的数量和库存量 如果大于库存量 直接返回错误
                    result.code = (int)HttpStatusCode.BadRequest;
                    result.isSuccess = false;
                    result.massage = "库存数量不足！";
                    return result;
                }

                drugModel.QUANTITY = quantity;
                

                DRUG_PRESC_DETAIL detail = new DRUG_PRESC_DETAIL()
                {
                    PRESC_DATE = prescDate,
                    PRESC_NO = prescNo,
                    DRUG_NAME = model.DRUG_NAME,
                    DRUG_CODE = model.DRUG_CODE,
                    PACKAGE_SPEC = drugModel.PACKAGE_SPEC,
                    QUANTITY = model.QUANTITY,
                    FIRM_ID = drugModel.FIRM_ID,
                    ITEM_NO = itemId,
                    PACKAGE_UNITS = drugModel.PACKAGE_UNITS,
                    COSTS = model.COSTS,
                    PAYMENTS = model.PAYMENTS,
                    DRUG_SPEC = drugModel.DRUG_SPEC
                };

                drugList.Add(drugModel);
                detailList.Add(detail);
            }
            



            //获取患者基本信息
            PAT_MASTER_INDEX PatIndexModel = patIndexRepository.FindById(patientId);

          

            DRUG_PRESC_MASTER master = new DRUG_PRESC_MASTER()
            {
                PRESC_DATE = prescDate,
                PRESC_NO = prescNo,
                
                PATIENT_ID = patientId,
                NAME = PatIndexModel.NAME,
                NAME_PHONETIC = PatIndexModel.NAME_PHONETIC,
                IDENTITY = PatIndexModel.IDENTITY,
                CHARGE_TYPE = PatIndexModel.CHARGE_TYPE,
                ORDERED_BY = orderBy,
                PRESC_ATTR = "住院处方",
                DISPENSARY = storage,
                PRESC_SOURCE = 1,
                PRESC_TYPE = 0,
                REPETITION = 1,
                COSTS = costSum,
                PAYMENTS = paymentSum,
                ENTERED_BY = enterBy
            };

           

            var flag = _repository.ReduceDrugStock(drugList, master, detailList);
            index.PRESC_DATE = prescDate;
            index.PRESC_NO = prescNo;
            if (flag)
            {
                result.code = (int)HttpStatusCode.OK;
                result.isSuccess = true;
                result.data = index;
            }
            else 
            {
                result.code = (int)HttpStatusCode.InternalServerError;
                result.isSuccess = false;
                result.massage = "服务器处理出错";
            }
            
            return result;
          
        }

        public ResultObj BackReduceDrugStock(List<InpChargeItemViewModel> modelList, DateTime prescDate, int prescNo, string storage)
        {
            ResultObj result = new ResultObj();
            if (modelList == null)
            {
                result.code = (int)HttpStatusCode.LengthRequired;
                result.isSuccess = false;
                result.massage = "参数为空";
                return result;
            }

            //组建传递dal中的药品表List
            List<DRUG_STOCK> drugList = new List<DRUG_STOCK>();
            foreach (var model in modelList)
            {
                //获取药品库存基本信息 
                DRUG_STOCK drugModel = _repository.FindByClause(m => m.DRUG_CODE == model.DRUG_CODE
                && m.STORAGE == storage);
                int quantity = drugModel.QUANTITY + model.QUANTITY;
                drugModel.QUANTITY = quantity;
                drugList.Add(drugModel);
            }

            List<DRUG_PRESC_DETAIL> detailList = detailRepository.FindListByClause(m => m.PRESC_DATE == prescDate
            && m.PRESC_NO == prescNo).ToList();

            DRUG_PRESC_MASTER master =masterRepository.FindByClause(m => m.PRESC_DATE == prescDate
            && m.PRESC_NO == prescNo);

            bool detailFalg = false;
            if (detailList.Count > 0) 
            {
                detailFalg = true;
            }
            bool masterFalg = false;
            if (master != null) 
            {
                masterFalg = true;
            }
            
            var flag = _repository.BackReduceDrugStock(drugList, prescDate, prescNo, detailFalg, masterFalg);
            if (flag)
            {
                result.code = (int)HttpStatusCode.OK;
                result.isSuccess = true;
            }
            else 
            {
                result.code = (int)HttpStatusCode.InternalServerError;
                result.isSuccess = false;
                result.massage = "服务器处理出错";
            }
            return result;
        }
    }
}
