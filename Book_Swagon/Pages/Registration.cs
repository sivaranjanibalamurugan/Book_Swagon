using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
    public class Registration
    {
        public  Registration(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li[2]/a")]
        [CacheLookup]
        public IWebElement signup;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtConfirmPwd")]
        [CacheLookup]
        public IWebElement confirmpassword;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
        [CacheLookup]
        public IWebElement submit;

    }
}
