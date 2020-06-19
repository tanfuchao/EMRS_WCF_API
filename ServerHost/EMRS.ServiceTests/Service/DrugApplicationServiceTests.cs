using EMRS.Mapper;
using EMRS.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace EMRS.Services.Tests
{
    [TestFixture()]
    public class DrugApplicationServiceTests
    {
        [Test()]
        public void InsertDrugApplicationTest()
        {
            //AutoMapperRegister();
            DrugApplicationService service = new DrugApplicationService();
            List<CreateDrugListViewModel> list = new List<CreateDrugListViewModel>();
            CreateDrugListViewModel model1 = new CreateDrugListViewModel()
            {
                Drug_Code = "111",
                Drug_Name = "111",
                Drug_Spec = "111",
                Enter_Date_Time = DateTime.Now,
                Package_Spec = "111",
                Package_Units = "111",
                Quantity = 1
            };
            CreateDrugListViewModel model2 = new CreateDrugListViewModel()
            {
                Drug_Code = "222",
                Drug_Name = "222",
                Drug_Spec = "222",
                Enter_Date_Time = DateTime.Now,
                Package_Spec = "222",
                Package_Units = "222",
                Quantity = 2
            };
            list.Add(model1);
            list.Add(model2);
            var result = service.InsertDrugApplication(list,"111","111");
            //Assert.IsTrue(result);
        }

        private static void AutoMapperRegister()
        {
            new AutoMapperStartupTask().Execute();
        }
    }
}