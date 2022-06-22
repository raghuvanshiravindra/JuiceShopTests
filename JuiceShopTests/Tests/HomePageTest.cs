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

    public class HomePageTest : BaseTest

    {
        [Test(Description = "This will pull up the Homepage")]
        [TestCase(TestName = "Verify HomePage")]

        public void HomePage()
        {
            PagesContext.HomePage.ClickDismiss();
            PagesContext.HomePage.GetPageTitle().Should().Be("OWASP Juice Shop");
            PagesContext.HomePage.GetItemOne().Should().Contain("Apple Juice (1000ml)");
            PagesContext.HomePage.GetItemTwo().Should().Contain("Apple Pomace");
            PagesContext.HomePage.GetItemThree().Should().Contain("Banana Juice (1000ml)");
            PagesContext.HomePage.GetItemFour().Should().Contain("Best Juice Shop Salesman Artwork");
            PagesContext.HomePage.GetItemFive().Should().Contain("Carrot Juice (1000ml)");
            PagesContext.HomePage.GetItemSix().Should().Contain("Eggfruit Juice (500ml)");
            PagesContext.HomePage.GetItemSeven().Should().Contain("Fruit Press");
            PagesContext.HomePage.GetItemEight().Should().Contain("Green Smoothie");
            PagesContext.HomePage.GetItemNine().Should().Contain("Permafrost");
            PagesContext.HomePage.GetItemTen().Should().Contain("Lemon Juice (500ml)");
            PagesContext.HomePage.GetItemEleven().Should().Contain("Melon Bike (Comeback-Product 2018 Edition)");
            PagesContext.HomePage.GetItemTwelve().Should().Contain("King of the Hill");
        }
    }
}
