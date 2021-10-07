using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualSportSeleniumTests
{
    public class AbstractPage
    {
        public SeleniumUtils seleniumutils;
        public IWebDriver driver;

        protected By loginHomeButton = By.CssSelector("a[automation='home_login_button']");
        protected By userName = By.CssSelector("input[automation='email_input']");
        protected By password = By.CssSelector("input[automation='password_input']");
        protected By loginButton = By.CssSelector("button[automation='login_button']");
        protected By afterloginpopup = By.Id("after_login_close");
        protected By digitainCategory = By.CssSelector("a[data-url='digitain']");
        protected By playButton = By.CssSelector(".lca-games-grid.grid_2 .lca-card.js_dl_games_cont .lca-card-hover.animate .lca-card-btn-wrapper.d-flex.align-items-center.justify-content-center.flexCol .h-bg-primary.game__link_real.js_dl_play");
        protected By singleWiev = By.CssSelector("a[title='Switch to single game mode']");
        protected By menuItems = By.CssSelector(".tl_header_navigation.tl_main_nav.flex.alCen.tl_bot_header_cont.tl_responsive_header_navigation a");
        protected By menuGroup = By.CssSelector(".lca-wrapper-shadow.flex-grow-1.d-flex a");
        protected By menuCategory = By.CssSelector(".lca-submenu-item.list-inline-item a");
        protected string gameName = "virtual sports";
        protected string groupName = "all";
        // protected string categoryName = "digitain";

        public void GetMenuItem()
        {
            seleniumutils.GetElementFromList(menuItems, gameName);
        }

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            this.seleniumutils = new SeleniumUtils(driver);
        }

        public void Clicklogin()
        {
            seleniumutils.Click(loginHomeButton);
            seleniumutils.Sleep(1000);
        }
        public void Login()
        {
            seleniumutils.ClickAndSend(userName, "Digitaintestamd");
            seleniumutils.ClickAndSend(password, "a12345678");
            seleniumutils.Click(loginButton);
        }
        public void AfterLoginPopup()
        {
            seleniumutils.Wait(afterloginpopup, 10);
            seleniumutils.Click(afterloginpopup);
        }

        public void clickAllGroup()
        {
            seleniumutils.GetElementFromList(menuGroup, groupName);

        }
        public void clickDigitainCategory()
        {
            seleniumutils.Click(digitainCategory);

        }
        public void clickPlayButton()
        {
            seleniumutils.Click(playButton);

        }
        public bool elementIsDisplayed()
        {
            return seleniumutils.IsDisplayed(singleWiev);
        }


    }



}

