using Authorization.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace TestAutorization
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void UserNotExist()
        {

            var page = new AuthPage();
            Assert.IsFalse(page.Auth("ramazotti", "italyan_music12"));


        }
    }
}
