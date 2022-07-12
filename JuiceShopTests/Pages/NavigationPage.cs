using Framework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class NavigationPage : BasePage
    {

        public NavigationPage(IWebDriver driver) : base(driver) { }
        By sideNavBtn = By.XPath("//*[@aria-label='Open Sidenav']");
        By sideNavTitle = By.XPath("//h2");
        By viewLabel = By.XPath("//h1");
        By cutomerFeedbackBtn = By.XPath("//*[@class='mat-list-item-content']//*[text()=' Customer Feedback ']");
        By accountLbl = By.XPath("//*[@class='appVersion']//*[text()='OWASP Juice Shop']");
        By aboutUsBtn = By.XPath("//*[@class='mat-list-item-content']//*[text()=' About Us ']");
        By photoWallBtn = By.XPath("//*[@class='mat-list-item-content']//*[text()=' Photo Wall ']");
        By scoreBoard = By.XPath("//*[@class='mat-list-item-content']//*[text()=' Score Board ']");
        By scoreBoardLbl = By.XPath("//*[@class='mat-card mat-focus-indicator']//*[text()='Score Board ']");
        By sideNavVisible = By.XPath("//*[@class='mat-drawer mat-sidenav ng-tns-c220-0 ng-trigger ng-trigger-transform mat-drawer-over ng-star-inserted']");

        public NavigationPage ClickSideNavigationBtn()
        {
            WaitHelper.WaitForElementPresent(Driver, sideNavVisible, TimeSpan.FromSeconds(30));
            WaitHelper.WaitForElementPresent(Driver, sideNavBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String AccountLabel()
        {
            WaitHelper.WaitForElementVisible(Driver, accountLbl, TimeSpan.FromSeconds(8));
            return FindVisibleElement(accountLbl, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetViewLabel()
        {
            return FindVisibleElement(viewLabel, TimeSpan.FromSeconds(8)).Text;
            
        }
        public NavigationPage ClickCustomerFeedback()
        {
            WaitHelper.WaitForElementPresent(Driver, cutomerFeedbackBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public NavigationPage ClickAboutUs()
        {
            WaitHelper.WaitForElementVisible(Driver, aboutUsBtn, TimeSpan.FromSeconds(30)).Click();

            return this;
        }
        public NavigationPage ClickPhotoWall()
        {
            WaitHelper.WaitForElementPresent(Driver, photoWallBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public NavigationPage ClickScoreBoard()
        {
            WaitHelper.WaitForElementPresent(Driver, scoreBoard, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String GetScoreBoardLabel()
        {
            return FindVisibleElement(scoreBoardLbl, TimeSpan.FromSeconds(8)).Text;
        }

    }
}
