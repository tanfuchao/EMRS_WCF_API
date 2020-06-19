using NUnit.Framework;
using EMRS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EMRS.Services.Tests
{
    [TestFixture()]
    public class DrugPriceServiceTests
    {
        private readonly IDrugPriceService _repository = new DrugPriceService();
        [Test()]
        public void GetAutoCreateDrugListTest()
        {
            var list = _repository.GetAutoCreateDrugList("221011B");
           
            //Assert.IsTrue(list.Count>0);
        }

        [Test()]
        public void GetChooseDrugSizeByCodeTest()
        {
            //var list = _repository.GetChooseDrugSizeByCode("261102", "14D0024TAG").ToList();

            //Assert.IsTrue(list.Count > 0);
        }

        [Test()]
        public void Test()
        {
            Debug.WriteLine("12312");


        }

       
    }
}