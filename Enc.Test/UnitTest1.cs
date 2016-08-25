using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enc.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var text = "Hello";
            var enc = new Enc.Models.Encrypto();
            var cipher = enc.Encrypt(text, enc.PublicKey);
            var plain = enc.Decrypt(cipher, enc.PrivateKey);
            Assert.AreEqual<string>(text, plain);
        }
    }
}
