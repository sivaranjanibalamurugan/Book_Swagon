using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
   public  class Payment
    {
        public Payment(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       
        [FindsBy(How = How.LinkText, Using = "Gift Certificate ")]
        [CacheLookup]
        public IWebElement gift;
    }
}
