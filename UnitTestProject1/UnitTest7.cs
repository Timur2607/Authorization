using Authorization.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace TestAutorization
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void PasswordIsEmpty()
        {
            var page = new AuthPage();
            Assert.IsFalse(page.Auth("Timka2607", ""));
        }
    }
}
