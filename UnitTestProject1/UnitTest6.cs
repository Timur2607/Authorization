using Authorization.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void LoginIsEmpty()
        {
            var page = new AuthPage();
            Assert.IsFalse(page.Auth("", "my_car_07"));

        }
    }
}
