using CFA.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private IServices _service;
        private string _str;

        [TestInitialize]
        public void Initialize()
        {
            _service = new Services();
            _str = 
            "{{}}"
            ;
        }

        [TestMethod]
        public void CheckAddMethod()
        {
            var result = _service.Add(_str);
            Assert.AreEqual(3, result);
        }
    }
}
