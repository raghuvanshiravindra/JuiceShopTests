﻿using Framework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) : base(driver) { }
        By accountBtn = By.Id("navbarAccount");
        By acctLoginBtn = By.Id("navbarLoginButton");
        By emailAddress = By.Name("email");
        By password = By.Name("password");
        By loginBtn = By.Id("loginButton");
        By yourBasketBtn = By.XPath("//*[@aria-label='Show the shopping cart']"); 
        By viewLabel = By.XPath("//h1");
        By invalidEmail = By.XPath("//*[@class='error ng-star-inserted']");
        By notACustomer = By.Id("newCustomerLink");
        By regEmail = By.Id("emailControl");



        public LoginPage ClickAccount()
        {
            WaitHelper.WaitForElementPresent(Driver, accountBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public LoginPage ClickAccountLogin()
        {
            WaitHelper.WaitForElementPresent(Driver, acctLoginBtn, TimeSpan.FromSeconds(30)).Click();
                        return this;
        }
        public LoginPage EnterEmail(String text)
        {
            GetElement(emailAddress, TimeSpan.FromSeconds(8)).SendKeys(text);
            return this;
        }
        public LoginPage EnterPassword(String text)
        {
            GetElement(password, TimeSpan.FromSeconds(8)).SendKeys(text);
            return this;
        }
        public LoginPage ClickLogin()
        {
            Thread.Sleep(6000);
            WaitHelper.WaitForElementPresent(Driver, loginBtn, TimeSpan.FromSeconds(30)).Click();
            if (WaitHelper.WaitForElementPresent(Driver, invalidEmail, TimeSpan.FromSeconds(8)).Displayed == true)                     
            WaitHelper.WaitForElementPresent(Driver, notACustomer, TimeSpan.FromSeconds(30)).Click();

            else
            return this;
            
            return this;
        }
        public LoginPage ClickYourBasket()
        {
            WaitHelper.WaitForElementPresent(Driver, yourBasketBtn, TimeSpan.FromSeconds(30)).Click();
            return this;
        }
        public String GetViewLabel()
        {
            return FindVisibleElement(viewLabel, TimeSpan.FromSeconds(8)).Text;
        }

    }
}
