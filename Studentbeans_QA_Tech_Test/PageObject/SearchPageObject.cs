using OpenQA.Selenium;
using Studentbeans_QA_Tech_Test.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Studentbeans_QA_Tech_Test.PageObject
{
    class SearchPageObject
    {

        public SearchPageObject()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }



        IWebElement searchBar => driver.FindElement(By.XPath("//input[@name='query']"));

        public void ClickSearchBar()
        {
            searchBar.Click();
        }


        IWebElement text => driver.FindElement(By.XPath("//input[@class='_1g5dvk1']"));

        public void EnterText(string brand)
        {
            Thread.Sleep(3000);
            text.SendKeys(brand);
            Thread.Sleep(3000);
        }


        IWebElement confirmSamsungDiscountIsDisplayed => driver.FindElement(By.XPath("//span[text()='10% off the new Galaxy Buds Pro']"));


        public bool IsSamsungDiscountDisplayed()
        {
            return confirmSamsungDiscountIsDisplayed.Displayed;
        }



    }
}
