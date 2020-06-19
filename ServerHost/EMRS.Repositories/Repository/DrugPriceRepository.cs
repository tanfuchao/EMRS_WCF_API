using EMRS.Domain;
using EMRS.Repositories;
using EMRS.Model;
using SqlSugar;
using System.Collections.Generic;

namespace EMRS_Repository
{
    public class DrugPriceRepository : GenericRepository<DRUG_PRICE_LIST>, IDrugPriceRepository
    {
        public IEnumerable<ChooseDrugSizeViewModel> GetChooseDrugSizeByCode(string code)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                string sql = @"SELECT DISTINCT 
                                                drug_code as DrugCode,
                                                drug_spec as DrugSpec,
                                                units as Units,
                                                min_spec as MinSpec,
                                                min_units as MinUnits,
                                                firm_id as FirmId,
                                                amount_per_package as AmountPerPackage,
                                                trade_price as TradePrice,
                                                retail_price as RetailPrice
                            FROM drug_price_list
                            WHERE drug_code = @drug_code
                            AND start_date <= sysdate
                            AND(stop_date IS NULL OR stop_date >= sysdate)";
                var list = db.Ado.SqlQuery<ChooseDrugSizeViewModel>(sql, new List<SugarParameter>() {
                    new SugarParameter("@drug_code",code)
                });
                return list;
            }
        }


        public IEnumerable<CreateDrugListViewModel> GetAutoCreateDrugList(string code)
        {
            using (var db = DbFactory.GetSqlSugarClient())
            {
                string sql = @"SELECT DISTINCT drug_name as Drug_Name,
                                            drug_stock.drug_code as Drug_Code,
                                            drug_stock.drug_spec as Drug_Spec,
                                            package_spec as Package_Spec,
                                            package_units as Package_Units,
                                            drug_stock.EXPIRE_DATE as Expire_Date
                            FROM drug_stock, drug_dict
                            WHERE drug_stock.drug_code = drug_dict.drug_code
                            AND storage = @code";
                var list = db.Ado.SqlQuery<CreateDrugListViewModel>(sql, new List<SugarParameter>() {
                    new SugarParameter("@code",code)
                });
                return list;
            }

        }
    }
}
