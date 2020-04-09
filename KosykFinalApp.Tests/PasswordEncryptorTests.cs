using System;
using KosykFinalApp.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KosykFinalApp.Tests
{
    [TestClass]
    public class PasswordEncryptorTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(PasswordEncryptor.Encrypt("test1"), PasswordEncryptor.Encrypt("test1"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreNotEqual(PasswordEncryptor.Encrypt("test2"), PasswordEncryptor.Encrypt("test1"));
        }
    }
}
