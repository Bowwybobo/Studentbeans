using NUnit.Framework;
using Studentbeans_QA_Tech_Test.PageObject;
using System;
using TechTalk.SpecFlow;

namespace Studentbeans_QA_Tech_Test.StepDefinition
{
    [Binding]
    public class SimpleSearchSteps
    {
        SearchPageObject searchPageObject;
        

        public SimpleSearchSteps()
    {
        searchPageObject = new SearchPageObject();
    }


        [Given(@"I am on the studentbeans homepage ""(.*)""")]
        public void GivenIAmOnTheStudentbeansHomepage(string url)
        {
            searchPageObject.NavigateToWebsite(url);
        }
        
        [Given(@"I open the search bar")]
        public void GivenIOpenTheSearchBar()
        {
            searchPageObject.ClickSearchBar();
        }
        
        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string brand)
        {
            searchPageObject.EnterText(brand);
        }
        
        [Then(@"I should be shown a search listing for samsung")]
        public void ThenIShouldBeShownASearchListingForSamsung()
        {
            Assert.That(searchPageObject.IsSamsungDiscountDisplayed);
        }
    }
}
