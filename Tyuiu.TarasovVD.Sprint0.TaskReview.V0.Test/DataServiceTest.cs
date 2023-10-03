using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TarasovVD.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.TarasovVD.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 1;
            int y = 1;
            int z = 1;
            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(res, res);
            
        }
    }
}
