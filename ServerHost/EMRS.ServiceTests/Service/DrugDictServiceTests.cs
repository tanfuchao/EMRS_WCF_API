using NUnit.Framework;
using EMRS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRS.Services.Tests
{
    [TestFixture()]
    public class DrugDictServiceTests
    {
        private readonly IDrugDictService service = new DrugDictService();
        [Test()]
        public void GetDrugDetailTest()
        {
            var list = service.GetDrugDetail("2306211", "14D0024TAG");
            //Assert.IsTrue(list.Count > 0);
            var lsit2 = service.GetDrugDetail("261102", "14D0024TAG");
            //Assert.IsTrue(list==null);
        }


    }
}