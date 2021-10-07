using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Book_Swagon
{
    [TestFixture]
    [AllureNUnit]
    public class Tests:Base.BaseClass
    {
         [Test,Order(0)]
             public void AssertTitle()
             {
                  DoActions.DoActions.AssertAfterLaunching(driver);
             }

           [Test,Order(1)]
             public void signin()
             {
                DoActions.DoActions.signup(driver);
             }
           [Test(Description = "Login")]
           [AllureTag("Regression")]
           [AllureSeverity(SeverityLevel.critical)]
           [AllureIssue("ISSUE-1")]
           [AllureTms("TMS-12")]
           [AllureOwner("User")]
           [AllureSuite("PassedSuite")]
           [AllureSubSuite("NoAssert")]
          //  [Test,Order(2)]
              public void createAccount()
              {
                  DoActions.DoActions.Login(driver);
                  Takescreenshot();
              }
            [Test,Order(3)]
              public void searchBook()
              {
                  DoActions.DoActions.search(driver);
                  Takescreenshot();
              }
              [Test,Order(4)]
                public void buyNow()
                {
                    DoActions.DoActions.placeorder(driver);
                    Takescreenshot();
                }
              [Test,Order(5)]
              public void shipping()
              {
                DoActions.DoActions.Shippingaddress(driver);
                Takescreenshot();
              }
              [Test,Order(6)]
              public void ReviewPage()
              {
                DoActions.DoActions.reviewOrder(driver);
                Takescreenshot();
              }
             [Test,Order(7)]
              public void payment()
              {
                DoActions.DoActions.payment(driver);
                Takescreenshot();
              }
           [Test, Order(6)]
          public void Sendingmail()
           {

                   //driver.Url ="https://accounts.google.com/ServiceLogin/identifier?";
                   Pages.Mail.ReadDataFromExcel(driver);
                   Pages.Mail.email_send(driver);
                   //Calling the screenshot method
                   Takescreenshot();

           }
            [Test,Order(7)]
           public void NegativeTestcase()
           {
             DoActions.DoActions.NegativeTest(driver);
             Takescreenshot();
           }
    }
}