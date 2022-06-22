using FluentAssertions;
using JuiceShopTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Tests
{
    [TestFixture]

    public class MenuNavigationTest : BaseTest

    {
        [Test(Description = "This will verify hamburger navigation")]
        [TestCase(TestName = "Verify Navigation")]

        public void MenuNavigation()
        {
            PagesContext.HomePage.ClickDismiss();
            PagesContext.HomePage.GetPageTitle().Should().Be("OWASP Juice Shop");
            PagesContext.NavigationPage.ClickSideNavigationBtn();
            PagesContext.NavigationPage.AccountLabel().Should().Be("OWASP Juice Shop");
            PagesContext.NavigationPage.ClickCustomerFeedback();
            PagesContext.NavigationPage.GetViewLabel().Should().Be("Customer Feedback");
            PagesContext.NavigationPage.ClickSideNavigationBtn();
            PagesContext.NavigationPage.AccountLabel().Should().Be("OWASP Juice Shop");
            PagesContext.NavigationPage.ClickAboutUs();
            PagesContext.NavigationPage.GetViewLabel().Should().Be("TITLE_ABOUT");
            PagesContext.NavigationPage.ClickSideNavigationBtn();
            PagesContext.NavigationPage.AccountLabel().Should().Be("OWASP Juice Shop");
            PagesContext.NavigationPage.ClickPhotoWall();
            PagesContext.NavigationPage.GetViewLabel().Should().Be("Photo Wall");
            PagesContext.NavigationPage.ClickSideNavigationBtn();
            PagesContext.NavigationPage.AccountLabel().Should().Be("OWASP Juice Shop");
            PagesContext.NavigationPage.ClickScoreBoard();
            PagesContext.NavigationPage.GetScoreBoardLabel().Should().Contain("Score Board");
        }
    }
}
