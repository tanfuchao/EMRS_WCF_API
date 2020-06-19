using NUnit.Framework;
using EMRS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMRS.Model;

namespace EMRS.Services.Tests
{
    [TestFixture()]
    public class DrugStockServiceTests
    {
        [Test()]
        public void GetChooseDrugListByStorageTest()
        {
            IDrugStockService service = new DrugStockService();
            var list = service.GetChooseDrugListByStorage("230626");
            Assert.IsTrue(list != null);
            //Assert.IsTrue(list.Count > 0);
        }

        [Test()]
        public void GetDrugCheckTest()
        {
            IDrugStockService service = new DrugStockService();
            var list = service.GetDrugCheck("210411B");
            //Assert.IsTrue(list.Count > 0);
        }

        [Test()]
        public void ReduceDrugStockTest()
        {
            IDrugStockService service = new DrugStockService();
            List<InpChargeItemViewModel> list = new List<InpChargeItemViewModel>();
            InpChargeItemViewModel model1 = new InpChargeItemViewModel()
            {
                DRUG_NAME = "AA",
                PAYMENTS = Convert.ToDecimal(5.5),
                COSTS = Convert.ToDecimal(1.1),
                QUANTITY = 5,
                DRUG_CODE = "13C0007IJG"
            };
            InpChargeItemViewModel model2 = new InpChargeItemViewModel()
            {
                DRUG_NAME = "BB",
                PAYMENTS = Convert.ToDecimal(4.4),
                COSTS = Convert.ToDecimal(2.2),
                QUANTITY = 2,
                DRUG_CODE = "01Z0004IJJ"
            };
            list.Add(model1);
            list.Add(model2);
            var result = service.ReduceDrugStock(list, "8666111", "210411B", "kkkk", "mmmm");
            //Assert.IsTrue(result.flag);

        }

        [Test()]
        public void BackReduceDrugStockTest()
        {
            IDrugStockService service = new DrugStockService();
            List<InpChargeItemViewModel> list = new List<InpChargeItemViewModel>();
            InpChargeItemViewModel model1 = new InpChargeItemViewModel()
            {
                DRUG_NAME = "AA",
                PAYMENTS = Convert.ToDecimal(5.5),
                COSTS = Convert.ToDecimal(1.1),
                QUANTITY = 5,
                DRUG_CODE = "13C0007IJG"
            };
            InpChargeItemViewModel model2 = new InpChargeItemViewModel()
            {
                DRUG_NAME = "BB",
                PAYMENTS = Convert.ToDecimal(4.4),
                COSTS = Convert.ToDecimal(2.2),
                QUANTITY = 2,
                DRUG_CODE = "01Z0004IJJ"
            };
            list.Add(model1);
            list.Add(model2);
            var result = service.BackReduceDrugStock(list, Convert.ToDateTime("2020-06-17 18:05:28"), 1314,"210411B");
            //Assert.IsTrue(result);
        }
    }
}