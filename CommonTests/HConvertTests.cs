using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Common.Tests
{
    [TestClass()]
    public class HConvertTests
    {
        [TestMethod()]
        public void ToIntTest()
        {
            Assert.AreEqual(12, HConvert.ToInt("12"));
        }

        [TestMethod()]
        public void ToDoubleTest()
        {
            var mo = new Mock<System.Web.HttpContextBase>();
            
            Assert.AreEqual(12.2,HConvert.ToDouble("12.2"));
        }
    }
}