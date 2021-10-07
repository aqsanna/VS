using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSportSeleniumTests
{
    public class CheckVirtualSportTest : Driver
    {
        AbstractPage abstractPage;
        SeleniumUtils selenium;

        [SetUp]
        public void Setup()
        {
            abstractPage = new AbstractPage(driver);
            selenium = new SeleniumUtils(driver);
        }
        [Test]
        public void chechVirtualSport()
        {
            abstractPage.Clicklogin();
            abstractPage.Login();
            abstractPage.AfterLoginPopup();
            abstractPage.GetMenuItem();
            selenium.Scroll();
            abstractPage.clickAllGroup();
            abstractPage.clickDigitainCategory();
            selenium.Scroll();
            abstractPage.clickPlayButton();
            bool gameView = abstractPage.elementIsDisplayed();
            Assert.AreEqual(gameView, true);
        }
    }


}
