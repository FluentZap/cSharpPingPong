using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PingPong;

namespace PingPongTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void ConvertNumberTest1()
        {
            var test = new PingPong.PingPong();
            Assert.AreEqual("1", test.ConvertNumber(1));                       

        }

        [TestMethod]
        public void ConvertNumberTestDivisibleBy3()
        {
            var test = new PingPong.PingPong();
            Assert.AreEqual("Ping", test.ConvertNumber(3));

        }

        [TestMethod]
        public void ConvertNumberTestDivisibleBy5()
        {
            var test = new PingPong.PingPong();
            Assert.AreEqual("Pong", test.ConvertNumber(5));

        }

        [TestMethod]
        public void ConvertNumberTestDivisibleBy3And5()
        {
            var test = new PingPong.PingPong();
            Assert.AreEqual("Ping-Pong", test.ConvertNumber(15));

        }

        [TestMethod]
        public void PingPongTestCount123()
        {
            var test = new PingPong.PingPong();
            List<string> testList = new List<string>() 
            { "1", "2", "Ping", "4", "Pong", "Ping", "7", "8", 
                "Ping", "Pong", "11", "Ping", "13", "14", "Ping-Pong" };
            
            for (int i = 0; i < 15; i++)
            {
				Assert.AreEqual(testList[i], test.PingPongIt(15)[i]);
            }

        }
    }
}
