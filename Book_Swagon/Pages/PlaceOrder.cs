using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
    public class PlaceOrder 
    {
      public  PlaceOrder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        /*   [FindsBy(How = How.XPath, Using = "/html/body/form/div[4]/div[2]/div[2]/div[1]/div[2]/div/div[2]/div/div[2]/div/div[2]/div[1]/div[3]/div[5]/input")]
        [CacheLookup]
        public IWebElement select;*/      

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[4]/div[4]/table[1]/tbody[1]/tr[3]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div[2]/div/div/div[4]/table/tbody/tr/td[3]/input")]
        [CacheLookup]
        public IWebElement placeorder;

        [FindsBy(How = How.ClassName, Using = "btn-red")]
        [CacheLookup]
        public IWebElement continuebt;



    }
}
