using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;

namespace Assignment1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOption1()
        {
            var test = new Program();
            int x = 0;
           x = test.Option1();

            Assert.IsTrue (x<=10 & x>=1); // Test if value is in range
           Assert.IsNotNull (x);  //Make sure RNG isn't returning null

        }

        [TestMethod]
        public void TestOption2()
        {
            var test = new Program();
            string x = "";
            x = test.Option2();

            Assert.AreEqual("2/18/2024", x); // Have to change string to the today's date to test
            Assert.AreNotEqual("00/00/0000", x);
                    

        }

        [TestMethod]
        public void TestOption3()
        {
            var test = new Program();
            string s = "";
            s = test.Option3();
            Assert.AreNotEqual("Godzilla", s);  // Make sure Option3 isn't printing something wrong



        }
    }
}