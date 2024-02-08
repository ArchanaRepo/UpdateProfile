using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support;

using SeleniumExtras.PageObjects;
using System.Threading;
using OpenQA.Selenium.Interactions;
using static System.Net.Mime.MediaTypeNames;
using log4net;


namespace NaukriUpdate.Pages
{
    [Binding]
    public class NaukriLoginPage : BasePage
    {
        public IWebDriver driver;
        private static readonly ILog log = LogManager.GetLogger(typeof(NaukriLoginPage));


       By UserName = By.Id("usernameField");
        By Password = By.Id("passwordField");
        By LoginButton = By.XPath("//button[text()='Login']");
        By ProfileLink = By.XPath("//div[@class='view-profile-wrapper']//a[@href='/mnjuser/profile']");
        By ResumeHeadlineEditIcon = By.XPath("//div[@class='resumeHeadline']//span[@class='edit icon']");
        By ResumeHeadLineTextArea = By.XPath("//textArea[@id='resumeHeadlineTxt']");
        By ResumeHeadLineSaveButto = By.XPath("//form[@name='resumeHeadlineForm']//button[text()='Save']");
        By ResumeHeadline = By.XPath("//div[@class='resumeHeadline']//div[@class='prefill typ-14Medium']/div");
        By BasicDetailsEditIcon = By.XPath("//span[@class='fullname']/..//em[text()='editOneTheme']");
        By NameTextBox = By.XPath("//input[@id='name']");
        By SaveBasicDetailsButtonn = By.XPath("//button[@id='saveBasicDetailsBtn']");
        By FullNameText = By.XPath("//span[@class='fullname']");


        public void LaunchURL()
        {

           // ChromeOptions option= new ChromeOptions();
            log.Info("initialized ChromeOption");
           // option.AddArgument("--headless");
            log.Info("Added headless option");
            driver=new ChromeDriver();
            log.Info("create new driver reference");
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/homepage");

            log.Info("Open URL");
            driver.Manage().Window.Maximize();
            log.Info("Maximize browser");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            log.Info("Added implicit wait");
            Thread.Sleep(5000);
            log.Info("added thread sleep");


        }
        public void LoginInPortal(string username,string password)
        {
            Thread.Sleep(10000);
            log.Info($"{username}:{password}");

            driver.FindElement(UserName).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            driver.FindElement(LoginButton).Click();    
            Thread.Sleep(1000);
        }

        public  void ClickOnProfile()
        {
            driver.FindElement(ProfileLink).Click();
            Thread.Sleep(1000);
        }

        public void ClickOnResumeHeadline()
        {
            driver.FindElement(ResumeHeadlineEditIcon).Click();
            Thread.Sleep(1000);
        }
        public void AddTextInResumeHeadlineTextArea(string text)
        {
            driver.FindElement(ResumeHeadLineTextArea).Clear();
            driver.FindElement(ResumeHeadLineTextArea).SendKeys(text);
            Thread.Sleep(2000);
        }

        public void CLickOnResumeHeadlineSaveButton()
        {
            driver.FindElement(ResumeHeadLineSaveButto).Click();
            Thread.Sleep(1000);

        }

        public bool CompareResumeHeadline(string expectedText)
        {
            Thread.Sleep(1000);
            Actions actions = new Actions(driver);
            IWebElement ele = driver.FindElement(ResumeHeadline);
            actions.MoveToElement(ele).Build().Perform();
            var headlineFromUI = driver.FindElement(ResumeHeadline).Text;
            if(expectedText.Equals(headlineFromUI))
                return true;
            else return false;
            
        }

        public void CloseBrowser()
        {
            driver.Close();
        }

        public void clickEditIconOnBasicDetails()
        {
            Thread.Sleep(1000);
            driver.FindElement(BasicDetailsEditIcon).Click();
            Thread.Sleep(5);
        }

        public void updateFullName(string fullName)
        {
            Thread.Sleep(5000);
            driver.FindElement(NameTextBox).Click();
             driver.FindElement(NameTextBox).Clear();
            Thread.Sleep(2000);
            driver.FindElement(NameTextBox).SendKeys(fullName);
            Thread.Sleep(5000);

        }

        public void ClickOnSaveBasicDetailsButton()
        {
            Thread.Sleep(5000);
            driver.FindElement(SaveBasicDetailsButtonn).Click();
            Thread.Sleep(5000);
        }

        public bool CompareUpdatedName(string expectedText)
        {
            Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            IWebElement ele = driver.FindElement(FullNameText);
            actions.MoveToElement(ele).Build().Perform();
            var fullNameFromUI = driver.FindElement(FullNameText).Text;
            if (expectedText.Equals(fullNameFromUI))
                return true;
            else return false;

        }
       

    }
}
