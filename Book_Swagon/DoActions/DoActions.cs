using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Swagon.DoActions
{
    class DoActions:Base.BaseClass
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Online Bookstore | Buy Books Online | Read Books Online";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
       public static void signup(IWebDriver driver)
        {
            try 
            { 
                //Creating instance for the page class
               Pages.Registration register = new Pages.Registration(driver);
                //To click on the signup
               register.signup.Click();
                //waiting time
               System.Threading.Thread.Sleep(4000);

                ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Book_Swagon\Book_Swagon\Resources\BS_Signup.xlsx");
                Debug.WriteLine("****");

               register.email.SendKeys(ExcelOperation.ReadData(1, "email"));
                System.Threading.Thread.Sleep(4000);

                register.password.SendKeys(ExcelOperation.ReadData(1, "password"));
                System.Threading.Thread.Sleep(4000);

                register.confirmpassword.SendKeys(ExcelOperation.ReadData(1, "confirmpassword"));
                System.Threading.Thread.Sleep(4000);

                register.submit.Click();
                System.Threading.Thread.Sleep(4000);


                //Validation
                string expected = "My Account";
               string actual = driver.FindElement(By.XPath("/html/body/form/div[4]/div[2]/div[1]/h1")).Text;
               Console.WriteLine("errorMeassage: {0}", actual);
               Assert.AreEqual(expected, actual);

               Console.WriteLine("signup Successfully");
            }
            catch
            {
                Console.WriteLine("signup Failed");
            }
        }

        public static void Login(IWebDriver driver)
        {
            try 
            { 
              //DoActions.signup(driver);
              //creating instance 
              Pages.Login login = new Pages.Login(driver);
              ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Book_Swagon\Book_Swagon\Resources\BS_Signup.xlsx");
              Debug.WriteLine("****");

              login.login.Click();
              System.Threading.Thread.Sleep(4000);

              login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
              System.Threading.Thread.Sleep(4000);

              login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
              System.Threading.Thread.Sleep(4000);

              login.LoginBt.Click();
              System.Threading.Thread.Sleep(4000);

               //Validation
                string expected = "Best seller";
                string actual = driver.FindElement(By.XPath("/html/body/form/div[4]/div[2]/div[2]/div[4]/div[1]/div/ul/li[1]/a")).Text;
                Assert.AreEqual(expected, actual);

                Console.WriteLine("Login is Successful");
            }
            catch
            {
                Console.WriteLine("Login Failes");
            }
        }
        public static void search(IWebDriver driver)
        {
            try
            { 
                DoActions.Login(driver);
                 //creating instance
                Pages.Search search = new Pages.Search(driver);

                search.search.SendKeys("APJ");       
                search.search.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(4000);

                //Validation
                string expected = "17cse88sivaranjanib@";
                string actual = driver.FindElement(By.XPath("/html/body/form/div[4]/div[1]/div[1]/div/div[4]/div[1]/ul/li/a/span")).Text;
                Assert.AreEqual(expected, actual);

                search.wishlist.Click();
                System.Threading.Thread.Sleep(4000);

                Console.WriteLine("searched product displayed");
            }
            catch
            {
                Console.WriteLine("searching Failed");
            }  
        }
        public static void placeorder(IWebDriver driver)
        {
           try 
           { 
            DoActions.search(driver);
            Pages.PlaceOrder order = new Pages.PlaceOrder(driver);

            // order.select.Click();
            // System.Threading.Thread.Sleep(4000);

            order.buynow.Click();
            System.Threading.Thread.Sleep(8000);

            driver.SwitchTo().Frame(0);

            order.placeorder.Click();
            System.Threading.Thread.Sleep(4000);

            //Validation
            string expected = "Your order details will be sent to this email address.";
            string actual = driver.FindElement(By.XPath("/html/body/form/div[3]/div[3]/div[2]/div[1]/div[2]/div/div/p[2]")).Text;
            Console.WriteLine("Meassage:{0}", actual);
            Assert.AreEqual(expected, actual);

                order.continuebt.Click();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Successful");
           }
            catch
           {
                Console.WriteLine("Failed");
           }
        }
        public static void Shippingaddress(IWebDriver driver)
        {
            try
            {
                DoActions.placeorder(driver);
                Pages.Shipping shipping = new Pages.Shipping(driver);
                ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Book_Swagon\Book_Swagon\Resources\BS_Shipping.xlsx");
                Debug.WriteLine("****");

                shipping.Name.SendKeys(ExcelOperation.ReadData(1, "Name"));
                System.Threading.Thread.Sleep(2000);

                shipping.CMname.SendKeys(ExcelOperation.ReadData(1, "CMname"));
                System.Threading.Thread.Sleep(2000);

                shipping.address.SendKeys(ExcelOperation.ReadData(1, "address"));
                System.Threading.Thread.Sleep(2000);

                shipping.country.SendKeys(ExcelOperation.ReadData(1, "country"));
                System.Threading.Thread.Sleep(2000);

                shipping.State.SendKeys(ExcelOperation.ReadData(1, "State"));
                System.Threading.Thread.Sleep(2000);

                shipping.city.SendKeys(ExcelOperation.ReadData(1, "city"));
                System.Threading.Thread.Sleep(2000);

                shipping.pincode.SendKeys(ExcelOperation.ReadData(1, "pincode"));
                System.Threading.Thread.Sleep(2000);

                shipping.phone.SendKeys(ExcelOperation.ReadData(1, "phone"));
                System.Threading.Thread.Sleep(4000);

                //shipping.select.Click();
                //System.Threading.Thread.Sleep(2000);

                shipping.save.Click();
                System.Threading.Thread.Sleep(4000);

                //Validation
                string expected = "Checkout Your Cart";
                string actual = driver.FindElement(By.XPath("/html/body/form/div[3]/div[3]/div[1]/h1")).Text;
                Console.WriteLine("Meassage:{0}", actual);
                Assert.AreEqual(expected, actual);

            }
            catch
            {
                Console.WriteLine("Errro");
            }
        }
        public static void reviewOrder(IWebDriver driver)
        {
            try
            {
                DoActions.Shippingaddress(driver);
                Pages.ReviewPage review = new Pages.ReviewPage(driver);

                review.reviewbtn.Click();
                System.Threading.Thread.Sleep(2000);

                //validation
                string expected ="Save&Continue";
                string actual = driver.FindElement(By.XPath("/html/body/form/div[3]/div[3]/div[2]/div[1]/div[2]/div[2]/div[2]/div[4]/div[2]/input")).Text;
                Console.WriteLine("Error Meassage:{0}", actual);
                Assert.AreEqual(expected, actual);

                Console.WriteLine("Order details");
            }
            catch
            {
                Console.WriteLine("Failes");
            }
        } 
        public static void payment(IWebDriver driver)
        {
            DoActions.reviewOrder(driver);
            Pages.Payment payment = new Pages.Payment(driver);

            payment.gift.Click();
            System.Threading.Thread.Sleep(2000);

            //Validation
            string expected = "Choose your mode of payment";
            string actual = driver.FindElement(By.XPath("/html/body/form/div[3]/div[3]/div[2]/div/div[2]/div[2]/div")).Text;
            Console.WriteLine("Error Meassage:{0}", actual);
            Assert.AreEqual(expected, actual);
        }
        public static void NegativeTest(IWebDriver driver)
        {
           try 
           { 
             Pages.LoginNs login = new Pages.LoginNs(driver);
             ExcelOperation.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Book_Swagon\Book_Swagon\Resources\Negativelogin.xlsx");
             Debug.WriteLine("****");

             login.login.Click();
             System.Threading.Thread.Sleep(4000);

             login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
             System.Threading.Thread.Sleep(4000);

             login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
             System.Threading.Thread.Sleep(4000);

             login.LoginBt.Click();
             System.Threading.Thread.Sleep(4000);

                //Validation
              string expected ="Please enter correct Email or Password.";
                string actual = driver.FindElement(By.Id("ctl00_phBody_SignIn_lblmsg")).Text;
                Console.WriteLine("Error Meassage:{0}", actual);
                Assert.AreEqual(expected, actual);
           //    Assert.True(login.ErrorMessage.Displayed);
                Console.WriteLine("Successful");
           }
            catch
           {
                Console.WriteLine("Failed");
           }
           
        }
     
    }
}
