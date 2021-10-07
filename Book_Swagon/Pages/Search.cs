using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
    public class Search
    {
        public Search(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$txtSearch")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[2]/div[3]/div[2]/div[1]/div[4]/div[5]/a[2]/input")]
        [CacheLookup]
        public IWebElement wishlist;
    }
}
