using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.Pages
{
   public class Shipping
    {
        public Shipping(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement Name;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement CMname;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement State;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCities")]
        [CacheLookup]
        public IWebElement  city;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPincode")]
        [CacheLookup]
        public IWebElement pincode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement phone;

       /* [FindsBy(How = How.Name, Using = "ctl00_cpBody_chkNewDefault")]
        [CacheLookup]
        public IWebElement select;*/

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement save;

   }
}
