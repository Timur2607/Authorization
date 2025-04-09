using Authorization.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void AuthTestNegative()
        {
            var page = new AuthPage();
            Assert.IsFalse(page.Auth("", ""));

        }
    }
}
