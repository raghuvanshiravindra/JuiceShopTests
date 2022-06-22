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
        By dismiss = By.XPath("/html//div[2]/button[2]/span[1]/span");
        By itemOne = By.XPath("//mat-grid-tile[1]/div/mat-card/div[1]/div[2]/div[1]");
        By itemTwo = By.XPath("//mat-grid-tile[2]/div/mat-card/div[1]/div[2]/div[1]");
        By itemThree = By.XPath("//mat-grid-tile[3]/div/mat-card/div[1]/div[2]/div[1]");
        By itemFour = By.XPath("//mat-grid-tile[4]/div/mat-card/div[2]/div[2]/div[1]");
        By itemFive = By.XPath("//mat-grid-tile[5]/div/mat-card/div[1]/div[2]/div[1]");
        By itemSix = By.XPath("//mat-grid-tile[6]/div/mat-card/div[1]/div[2]/div[1]");
        By itemSeven = By.XPath("//mat-grid-tile[7]/div/mat-card/div[1]/div[2]/div[1]");
        By itemEight = By.XPath("//mat-grid-tile[8]/div/mat-card/div[1]/div[2]/div[1]");
        By itemNine = By.XPath("//mat-grid-tile[9]/div/mat-card/div[2]/div[2]/div[1]");
        By itemTen = By.XPath("//mat-grid-tile[10]/div/mat-card/div[1]/div[2]/div[1]");
        By itemEleven = By.XPath("//mat-grid-tile[11]/div/mat-card/div[2]/div[2]/div[1]");
        By itemTwelve = By.XPath("//mat-grid-tile[12]/div/mat-card/div[2]/div[2]/div[1]");


        
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
