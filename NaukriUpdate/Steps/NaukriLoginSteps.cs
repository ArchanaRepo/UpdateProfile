using NaukriUpdate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NaukriUpdate.Steps
{
    [Binding]
    public class NaukriLoginSteps
    {
        NaukriLoginPage loginpage = new NaukriLoginPage();

        [Given(@"I launch Naukri portal")]
        public void LaunchNaukriPortal()
        {
            loginpage.LaunchURL();
        }

        [Given(@"I login using (.*) and (.*)")]
        public void LoginInPortal(string username, string password)
        {
            loginpage.LoginInPortal(username, password);
        }

        [When(@"I click on profile link")]
        public void WhenIClickOnProfileLink()
        {
            loginpage.ClickOnProfile();
        }

        [When(@"I click on Resume Headline Edit Icon")]
        public void WhenIClickOnResumeHeadlineEditIcon()
        {
            loginpage.ClickOnResumeHeadline();

        }

        [When(@"I enter ResumeHeadline as (.*)")]
        public void IEnterResumeHeadline(string text)
        {
            loginpage.AddTextInResumeHeadlineTextArea(text);
        }

        [When(@"I click on Resume Headline Save Button")]
        public void WhenIClickOnResumeHeadlineSaveButton()
        {
            loginpage.CLickOnResumeHeadlineSaveButton();
        }

        [Then(@"I Verify Resume Headline Updated Successfully with headline as (.*)")]
        public void ThenIVerifyResumeHeadlineUpdatedSuccessfully(string Headline)
        {
            Assert.That(loginpage.CompareResumeHeadline(Headline));
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            loginpage.CloseBrowser();
        }
        [When(@"I click on Basic Detals Edit Icon")]
        public void WhenIClickOnBasicDetalsEditIcon()
        {
            loginpage.clickEditIconOnBasicDetails();
        }
        [When(@"I update FullName as (.*)")]
        public void WhenIUpdateFullNameAsArchanaBShortNoticePeriod(string name)
        {
            loginpage.updateFullName(name);
        }
        [When(@"I click on save Basic Details Button")]
        public void WhenIClickOnSaveBasicDetailsButton()
        {
            loginpage.ClickOnSaveBasicDetailsButton();
        }
        [Then(@"I should see updated name in Full name as (.*)")]
        public void ThenIShouldSeeUpdatedNameInFullName(string updatedName)
        {
            Assert.That(loginpage.CompareUpdatedName(updatedName));
        }


    









    }
}
