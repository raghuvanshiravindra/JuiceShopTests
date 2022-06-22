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
        By cutomerFeedbackBtn = By.XPath("//sidenav/mat-nav-list/a[1]/span/i");
        By accountLbl = By.XPath("//mat-sidenav/div/sidenav/div/span/span[1]");
        By aboutUsBtn = By.XPath("//mat-nav-list/a[2]/span/span[3]");
        By photoWallBtn = By.XPath("//sidenav/mat-nav-list/a[3]/span/span[3]");
        By scoreBoard = By.XPath("//sidenav/mat-nav-list/a[4]/span/span[3]");
        By scoreBoardLbl = By.XPath("//div[1]/mat-card[1]/mat-card-title");

        public NavigationPage ClickSideNavigationBtn()
        {
            WaitHelper.WaitForElementPresent(Driver, sideNavBtn, TimeSpan.FromSeconds(30)).Click();
            WaitHelper.WaitForElementsVisible(Driver, accountLbl, TimeSpan.FromSeconds(30));
            return this;
        }
        public String AccountLabel()
        {
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
            WaitHelper.WaitForElementPresent(Driver, aboutUsBtn, TimeSpan.FromSeconds(30)).Click();
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
