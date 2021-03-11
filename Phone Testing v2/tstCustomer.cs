using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Phone_Testing_v2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }
    }
}
