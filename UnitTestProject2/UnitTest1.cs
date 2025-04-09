using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using Authorization.Pages;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Authorization.Pages.RegPage regPage = new Authorization.Pages.RegPage();

            // Входные данные для теста
            string fio = "Джавахишвили Георгий Рустамович";
            string login = "vahvah_hachapuri";
            string password = "aaaaVasya12"; // Должен быть на английском и содержать цифры
            string gender = "Мужской";
            string role = "Пользователь";
            string phoneNumber = "+77777875454"; // Должен соответствовать формату +7XXXXXXXXXX
            string photo = "path/to/vines.jpg";

            // Вызов метода Reg и проверка результата
            bool result = regPage.Reg(fio, login, password, gender, role, phoneNumber, photo);

            // Утверждение: метод должен вернуть true при успешной регистрации
            Assert.IsTrue(result, "Регистрация должна быть успешной с корректными данными");
        }
    }
}
