using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Base;
using Base.DomainModels;

namespace TestBase
{
    [TestClass]
    public class SalesOrderTest
    {
        [TestMethod]
        public void createEmptySalesOrder()
        {
            SalesOrder res = new SalesOrderFactory().createSalesOrder();

            Assert.IsNotNull(res.CreateDate);
        }

        [TestMethod]
        public void addALineToASalesOrder()
        {
            SalesOrderFactory s = new SalesOrderFactory();
            SalesOrder res = s.createSalesOrder();

            int lines = res.lines.Count;

            s.addSalesOrderLine(2,"Box",res);

            int linesAfter = res.lines.Count;

            Assert.IsTrue(linesAfter == (lines + 1));
        }

        

    }
}
