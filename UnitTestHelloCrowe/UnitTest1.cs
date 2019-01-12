using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloCrowe;

namespace UnitTestHelloCrowe
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTalkToMe()
        {
            //Test HelloWorld  
            HelloExercise.TalkToMe();
        }      
    }
}
