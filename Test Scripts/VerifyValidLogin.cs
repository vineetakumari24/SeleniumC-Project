using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserProcessor;
using NUnit.Framework;

namespace Test_Scripts
{


    [TestFixture]
    [Parallelizable]

    class VerifyValidLogin : TestBase
    {
        //public static IEnumerable<string> BrowserToRunWith()
        //{
        //    string[] browsers = { "Chrome", "Firefox" };
        //    foreach(string b in browsers)
        //    {
        //        yield return b;
        //    }
    //}
        

        [Test]
        //"BrowserToRunWith" is the method which pass the browser name to run
        [TestCaseSource(typeof(TestBase),"BrowserToRunWith")]
        public void VerifyLogin(string browserName)
        {
           /// string browserName = "Firefox";
            SetUp(browserName);
            driver.Url="www.google.com";
        }
    }
}
