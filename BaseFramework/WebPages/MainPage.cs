using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseFramework.WebPages
{
    public class MainPage
    {
        public static readonly string url = "http://ztestqa.com/selenium/mainpage.html";
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
