using BackgroundProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BackgroundProject.StepDefinition
{
    [Binding]
    public class BackgroundProjectSteps
    {
        BackgroundProjectPagecs backgroundProjectPagecs;
        public BackgroundProjectSteps()
        {
            backgroundProjectPagecs = new BackgroundProjectPagecs();
        }

        [Given(@"I navigate to""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            backgroundProjectPagecs.NavigateToWebsite(url);
            
        }

        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            backgroundProjectPagecs.ClickOnSignIn();
            
        }


        [When(@"I enter email text""(.*)""")]
        public void WhenIEnterEmailText(string Email)
        {
            backgroundProjectPagecs.EnterEmail(Email);
            
        }


       
        
        [When(@"I enter password text""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            backgroundProjectPagecs.EnterPassword(password);
        }
        
        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn2()
        {
            backgroundProjectPagecs.ClickOnSignIn2();
        }
        
        [When(@"I enter click on New Article")]
        public void WhenIEnterClickOnNewArticle()
        { 
            backgroundProjectPagecs.ClickOnNewArticle();
        }

        [When(@"I write my Article Title""(.*)""")]
        public void WhenIWriteMyArticleTitle(string DemoTesting)
        {
            backgroundProjectPagecs.EnterArticleTitle(DemoTesting);
        }

        [When(@"I write what my article is all about""(.*)""")]
        public void WhenIWriteWhatMyArticleIsAllAbout(string article)
        {
            backgroundProjectPagecs.EnterWhatArticleAbout(article);
        }

        [When(@"I write my Article""(.*)""")]
        public void WhenIWriteMyArticle(string test)
        {
            backgroundProjectPagecs.EnterWriteYourArticle(test);
            
        }

        [When(@"I enter tags""(.*)""")]
        public void WhenIEnterTags(string memo)
        {
            Thread.Sleep(5000);
            backgroundProjectPagecs.EnterTags(memo);
            
        }

        [When(@"I click on Publish Article")]
        public void WhenIClickOnPublishArticle()
        {
            backgroundProjectPagecs.ClickOnPublishArticle();
        }



        //[When(@"I click on Home")]
        //public void WhenIClickOnHome()
        //{
        //    backgroundProjectPagecs.ClickOnHome();
        //}

        //[Given(@"I click on Global Feed")]
        //public void GivenIClickOnGlobalFeed()
        //{
        //    backgroundProjectPagecs.ClickOnGlobalFeed();
        //}

        [When(@"I click on Global Feed")]
        public void WhenIClickOnGlobalFeed()
        {
            backgroundProjectPagecs.ClickOnGlobalFeed();
        }



        [Then(@"my article should be created successfully")]
        public void ThenMyArticleShouldBeCreatedSuccessfully()
        {
            Assert.That(backgroundProjectPagecs.IsPublishArticleDisplayed);
        }
        
        [Then(@"I should be able to see all global feed")]
        public void ThenIShouldBeAbleToSeeAllGlobalFeed()
        {
            Thread.Sleep(5000);
            Assert.That(backgroundProjectPagecs.IsAllGlobaFeedDisplayed);
        }
    }
}
