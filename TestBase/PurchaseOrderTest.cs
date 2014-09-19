using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Base;
using Base.DomainModels;

namespace TestBase
{
    [TestClass]
    public class PurchaseOrderTest
    {
        [TestMethod]
        public void createEmptyPurchaseOrder()
        {
            PurchaseOrder res = new PurchaseOrderFactory().createPurchaseOrder();

            Assert.IsNotNull(res.CreateDate);
        }

        [TestMethod]
        public void addALineToAPurchaseOrder()
        {
            PurchaseOrderFactory s = new PurchaseOrderFactory();
            PurchaseOrder res = s.createPurchaseOrder();

            int lines = res.Lines.Count;

            s.addPurchaseOrderLine(2, "Box", res);

            int linesAfter = res.Lines.Count;

            Assert.IsTrue(linesAfter == (lines + 1));
        }
    }
}
