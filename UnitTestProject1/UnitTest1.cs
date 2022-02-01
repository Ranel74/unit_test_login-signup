using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Window1 window1 = new Window1();
        MainWindow mainWindow = new MainWindow();
        [TestMethod]
        public void Auth()
        {
            string login = "kurech";
            string password = "qwerty";

            string expected = "Ранель";

            string result = window1.Authin(login, password);
            string actual = result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sign()
        {
            string name = "Иван";
            string login = "zolo";
            string password = "2004";

            bool expected = true;

            bool result = mainWindow.Signup(name, login, password);

            Assert.AreEqual(expected, result);
        }
    }
}
