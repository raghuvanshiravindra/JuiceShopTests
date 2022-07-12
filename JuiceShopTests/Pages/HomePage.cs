using Framework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver) { }
        By dismiss = By.XPath("//span[text()='Dismiss']");
        By itemOne = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Apple Juice (1000ml) ']");
        By itemTwo = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Apple Pomace ']");
        By itemThree = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Banana Juice (1000ml) ']");
        By itemFour = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Best Juice Shop Salesman Artwork ']");
        By itemFive = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Carrot Juice (1000ml) ']");
        By itemSix = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Eggfruit Juice (500ml) ']");
        By itemSeven = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Fruit Press ']");
        By itemEight = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Green Smoothie ']");
        By itemNine = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Juice Shop \"Permafrost\" 2020 Edition ']");
        By itemTen = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Lemon Juice (500ml) ']");
        By itemEleven = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' Melon Bike (Comeback-Product 2018 Edition) ']");
        By itemTwelve = By.XPath("//*[@class='mat-grid-tile-content']//*[text()=' OWASP Juice Shop \"King of the Hill\" Facemask ']");


        
        public String GetPageTitle()
        {
            return GetTitle();            
        }
        public HomePage ClickDismiss()
        {
            WaitHelper.WaitForElementPresent(Driver, dismiss, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String GetItemOne()
        {
            return FindVisibleElement(itemOne, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemTwo()
        {
            return FindVisibleElement(itemTwo, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemThree()
        {
            return FindVisibleElement(itemThree, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemFour()
        {
            return FindVisibleElement(itemFour, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemFive()
        {
            return FindVisibleElement(itemFive, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemSix()
        {
            return FindVisibleElement(itemSix, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemSeven()
        {
            return FindVisibleElement(itemSeven, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemEight()
        {
            return FindVisibleElement(itemEight, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemNine()
        {
            return FindVisibleElement(itemNine, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemTen()
        {
            return FindVisibleElement(itemTen, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemEleven()
        {
            return FindVisibleElement(itemEleven, TimeSpan.FromSeconds(8)).Text;
        }
        public String GetItemTwelve()
        {
            return FindVisibleElement(itemTwelve, TimeSpan.FromSeconds(8)).Text;
        }
    }
}
