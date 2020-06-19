using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace EMRS_Repository
{
    public class DrugStockRepository : GenericRepository<DRUG_STOCK>, IDrugStockRepository
    {

        public IEnumerable<ChooseDrugViewModel> GetChooseDrugListByStorage(string storage)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                //多表联查
                var list = db.Queryable<DRUG_STOCK, DRUG_NAME_DICT>((ds, dnd) => ds.DRUG_CODE == dnd.DRUG_CODE)
                    .Where((ds, dnd) => ds.STORAGE == storage)
                    .Where((ds, dnd) => dnd.STD_INDICATOR == 1)
                    .Select((ds, dnd) => new ChooseDrugViewModel { DrugCode = dnd.DRUG_CODE, DrugName = dnd.DRUG_NAME, InputCode = dnd.INPUT_CODE })
                    .ToList();
                return list;
            }
        }

        public bool ExistDrug(string stockId, string drugCode)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                bool result = db.Queryable<DRUG_STOCK>()
                    .Where(d => d.STORAGE == stockId)
                    .Where(d => d.DRUG_CODE == drugCode)
                    .Any();
                return result;
            }
        }

        public IEnumerable<DrugCheckViewModel> GetDrugCheck(string storage)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                //多表联查
                var list = db.Queryable<DRUG_STOCK, DRUG_NAME_DICT>((ds, dnd) => ds.DRUG_CODE == dnd.DRUG_CODE)
                    .Where((ds, dnd) => ds.STORAGE == storage)
                    .Where((ds, dnd) => dnd.STD_INDICATOR == 1)
                    .Select((ds, dnd) => new DrugCheckViewModel
                    {
                        DRUG_CODE = ds.DRUG_CODE,
                        DRUG_NAME = dnd.DRUG_NAME,
                        DRUG_SPEC = ds.DRUG_SPEC,
                        EXPIRE_DATE = ds.EXPIRE_DATE,
                        FIRM_ID = ds.FIRM_ID,
                        BATCH_NO = ds.BATCH_NO,
                        LOCATION = ds.LOCATION,
                        PURCHASE_PRICE = ds.PURCHASE_PRICE,
                        QUANTITY = ds.QUANTITY,
                        STORAGE = ds.STORAGE,
                        UNITS = ds.UNITS
                    })
                    .ToList();
                return list;
            }
        }

        public bool ReduceDrugStock(List<DRUG_STOCK> drugModelList, DRUG_PRESC_MASTER masterModel, List<DRUG_PRESC_DETAIL> detailModelList)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {

                try
                {

                    db.Ado.UseTran(() =>
                    {
                        db.Updateable(drugModelList).ExecuteCommand();
                        db.Insertable(masterModel).ExecuteCommand();
                        db.Insertable(detailModelList.ToArray()).ExecuteCommand();
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

        public bool BackReduceDrugStock(List<DRUG_STOCK> drugModelList, DateTime date, int no, bool detail, bool master)
        {
            try
            {
                using (var db = DbFactory.GetSqlSugarClient())
                {

                    db.Ado.UseTran(() =>
                    {

                        if (detail && master)
                        {
                            db.Updateable(drugModelList).ExecuteCommand();
                            db.Deleteable<DRUG_PRESC_DETAIL>()
                        .Where(d => d.PRESC_DATE == date)
                        .Where(d => d.PRESC_NO == no)
                        .ExecuteCommand();
                            db.Deleteable<DRUG_PRESC_MASTER>()
                        .Where(d => d.PRESC_DATE == date)
                        .Where(d => d.PRESC_NO == no)
                        .ExecuteCommand();
                        }


                    });

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;

            }

        }
    }
}
