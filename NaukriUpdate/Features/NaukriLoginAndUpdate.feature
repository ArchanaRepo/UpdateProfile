Feature: NaukriLoginAndUpdate

I should be able to update user  profile page

Scenario Outline: Verify User can update Resume Heading details in naukri profile_Archana
Given I launch Naukri portal
And I login using <UserName> and <Password>
When I click on profile link
And I click on Resume Headline Edit Icon
And I enter ResumeHeadline as <ResumeHeadline>
And I click on Resume Headline Save Button
Then I Verify Resume Headline Updated Successfully with headline as <ResumeHeadline>
And I close the browser

Examples: 
| UserName                     | Password  | ResumeHeadline                                                                                                                                                                                                                                    |
| archana.bangar2018@gmail.com | 123Shubh# | Java, C# Selenium Webdriver Automation Tester,Functional-Web Service Testing,SpecFlow,Accessibility Testing,API Testing,SQL,BDD,KDF,Cucumber,RESTAssure,Agile Scrum,Functional Testing,People Mangmnt,Defect tracking, JIRA,TestNG,HPALM,JUnit.   |
| archana.bangar2018@gmail.com | 123Shubh# | Java, C# Selenium Webdriver Automation Tester,Functional-Web Service Testing,SpecFlow,Accessibility Testing,API Testing,SQL,BDD,KDF,Cucumber,RESTAssure,Agile Scrum,Functional Testing,People Mangmnt,Defect tracking, JIRA,TestNG,HPALM,JUnit..  |
| archana.bangar2018@gmail.com | 123Shubh# | Java, C# Selenium Webdriver Automation Tester,Functional-Web Service Testing,SpecFlow,Accessibility Testing,API Testing,SQL,BDD,KDF,Cucumber,RESTAssure,Agile Scrum,Functional Testing,People Mangmnt,Defect tracking, JIRA,TestNG,HPALM,JUnit... |

@ignore
Scenario Outline: Verify User can update Resume Heading details in naukri profile_Shubham
Given I launch Naukri portal
And I login using <UserName> and <Password>
When I click on profile link
And I click on Resume Headline Edit Icon
And I enter ResumeHeadline as <ResumeHeadline>
And I click on Resume Headline Save Button
Then I Verify Resume Headline Updated Successfully with headline as <ResumeHeadline>
And I close the browser

Examples: 
| UserName                     | Password  | ResumeHeadline                                                                                                                                                                                                                                    |
| shubhamgagile@gmail.com      | 123Shubh@ | 14 yrs in Agile Program and Delivery,People Management,stakeholder management,Delivery Management, key metrics, budget,Risk, communication management, Delivery Leadership,Escalation Managmnt,Quality Management,CSM,PMP,PRINCE2certified        |
| shubhamgagile@gmail.com      | 123Shubh@ | 14 yrs in Agile Program and Delivery,People Management,stakeholder management,Delivery Management, key metrics, budget,Risk, communication management, Delivery Leadership,Escalation Managmnt,Quality Management,CSM,PMP,PRINCE2certified.       |
| shubhamgagile@gmail.com      | 123Shubh@ | 14 yrs in Agile Program and Delivery,People Management,stakeholder management,Delivery Management, key metrics, budget,Risk, communication management, Delivery Leadership,Escalation Managmnt,Quality Management,CSM,PMP,PRINCE2certified..      |


Scenario Outline: Verify User can update User Name details in naukri profile_Archana
Given I launch Naukri portal
And I login using <UserName> and <Password>
When I click on profile link
And I click on Basic Detals Edit Icon
And I update FullName as <FullName>
And I click on save Basic Details Button
Then I should see updated name in Full name as <FullName>
And I close the browser


Examples: 
| UserName                     | Password  | FullName                        |
| archana.bangar2018@gmail.com | 123Shubh# | Archana B Short Notice Period.  |
| archana.bangar2018@gmail.com | 123Shubh# | Archana Bangar Short Notice.    |
| archana.bangar2018@gmail.com | 123Shubh# | Archana B Avbl on Short Notice. |


@ignore
Scenario Outline: Verify User can update User Name details in naukri profile_Shubham
Given I launch Naukri portal
And I login using <UserName> and <Password>
When I click on profile link
And I click on Basic Detals Edit Icon
And I update FullName as <FullName>
And I click on save Basic Details Button
Then I should see updated name in Full name as <FullName>
And I close the browser



Examples: 
| UserName                     | Password  | FullName                        |
| shubhamgagile@gmail.com      | 123Shubh@ | Shubham Guptaa                  |
| shubhamgagile@gmail.com      | 123Shubh@ | Shubham Gupta                   |


