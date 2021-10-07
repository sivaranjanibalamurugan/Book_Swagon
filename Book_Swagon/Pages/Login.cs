using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
   public class Login
    {
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li[1]/a")]
        [CacheLookup]
        public IWebElement login;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement LoginBt;


   }
}
