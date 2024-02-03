using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NaukriUpdate.Pages
{
    [Binding]
    public class BasePage
    {
        public IWebDriver Driver { get; set; }
    }
}
