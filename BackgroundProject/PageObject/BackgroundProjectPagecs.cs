using BackgroundProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BackgroundProject.PageObject
{
    class BackgroundProjectPagecs
    {
        IWebDriver driver;
        public BackgroundProjectPagecs()
        {
            driver = Hooks1.driver;
            // ImplicitWait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }



        IWebElement SignIn => driver.FindElement(By.XPath("//a[@class='nav-link active']"));
        IWebElement emailInput => driver.FindElement(By.XPath("//*[@placeholder='Email']"));
        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement signIn2 => driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement newArticle => driver.FindElement(By.XPath("//ul[2]//li[2]//a[1]"));
        //IWebElement homeButton => driver.FindElement(By.XPath("//*[@class='nav-link active'])[1]"));
        IWebElement articleTitle => driver.FindElement(By.XPath("//input[@placeholder='Article Title']"));
        IWebElement aboutArticle => driver.FindElement(By.XPath("//input[@ng-model='$ctrl.article.description']"));
        IWebElement writeYourArticle => driver.FindElement(By.TagName("textarea"));
        IWebElement enterTags => driver.FindElement(By.XPath("//input[@ng-model='$ctrl.tagField']"));
        IWebElement publishArticle => driver.FindElement(By.XPath("//button[@type='button']"));
        IWebElement globalFeed => driver.FindElement(By.XPath("//a[contains(text(),'Global Feed')]"));













        public void ClickOnSignIn()
        {
            SignIn.Click();
        }

        public void ClickOnPublishArticle()
        {
            publishArticle.Click();
        }

        public void ClickOnGlobalFeed()
        {
            globalFeed.Click();
        }

        public void ClickOnNewArticle()
        {
            Thread.Sleep(5000);
            newArticle.Click();
        }

        //public void ClickOnHome()
        //{
        //    homeButton.Click();
        //}

        public void EnterArticleTitle(string DemoTesting)
        {
            Thread.Sleep(5000);
            articleTitle.SendKeys(DemoTesting);
        }

        public void EnterWriteYourArticle(string test)
        {
            Thread.Sleep(5000);
            writeYourArticle.SendKeys(test);
        }

        public void EnterTags(string memo)
        {
            Thread.Sleep(5000);
            enterTags.SendKeys(memo);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string Email)
        {
            emailInput.SendKeys(Email);
           
        }

        public void EnterWhatArticleAbout(string article)
        {
            aboutArticle.SendKeys(article);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickOnSignIn2()
        {
            signIn2.Click();
        }

        public bool IsPublishArticleDisplayed()
        {
            return publishArticle.Displayed;
        }

        public bool IsAllGlobaFeedDisplayed()
        {
            return globalFeed.Displayed;
        }
            












    }
}
