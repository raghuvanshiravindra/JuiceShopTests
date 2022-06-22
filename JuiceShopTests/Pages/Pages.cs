using Framework.Pages;
using OpenQA.Selenium;

namespace Framework
{
    public class Page
    {
        IWebDriver _driver;
        HomePage _HomePage;
        LoginPage _LoginPage;
        NavigationPage _NavigationPage;

        public Page(IWebDriver driver)
        {
            _driver = driver;
        }
        public void Register()
        {
            _HomePage = new HomePage(Driver);
            _LoginPage = new LoginPage(Driver);
            _NavigationPage = new NavigationPage(Driver);
        }
        public HomePage HomePage
        {
            get
            {
                return _HomePage;
            }
        }
        public LoginPage LoginPage 
        { 
            get 
            { 
                return _LoginPage; 
            } 
        }
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
        public NavigationPage NavigationPage
        {
            get 
            { 
                return _NavigationPage; 
            }
        }
    }
}