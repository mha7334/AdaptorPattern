using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdapterPattern;

namespace TestAdapter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITarget adapter = new VendorAdapter();

            var products = adapter.GetProducts();

            //4 items
            Assert.IsNotNull(products);
                        
        }
    }
}
