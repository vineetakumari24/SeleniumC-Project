using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace BrowserProcessor
{
    public class TestBase
    {
        protected IWebDriver driver;
        public  void SetUp(string BrowserName)
        {
            if (BrowserName.Equals("chrome"))
                driver = new ChromeDriver();
            else if (BrowserName.Equals("Firefox"))
                driver = new FirefoxDriver();

        }
        public static IEnumerable<string> BrowserToRunWith()
        {
            string[] browsers = { "Chrome", "Firefox" };
            foreach (string b in browsers)
            {
                yield return b;
            }
        }



        }
    }
