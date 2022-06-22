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

    public class LoginTest : BaseTest

    {
        [Test(Description = "This will verfify Login")]
        [TestCase(TestName = "Verify Login")]

        public void Login()
        {
            PagesContext.HomePage.ClickDismiss();
            PagesContext.HomePage.GetPageTitle().Should().Be("OWASP Juice Shop");
            PagesContext.LoginPage.ClickAccount();
            PagesContext.LoginPage.ClickAccountLogin();
            PagesContext.LoginPage.EnterEmail("jeanninesworld@hotmail.com");
            PagesContext.LoginPage.EnterPassword("Password");
            PagesContext.LoginPage.ClickLogin();
            PagesContext.LoginPage.ClickYourBasket();
            PagesContext.LoginPage.GetViewLabel().Should().Be("Your Basket");
        }
    }
}
