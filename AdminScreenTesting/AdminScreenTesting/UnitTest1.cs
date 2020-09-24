using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace AdminScreenTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            //navigate and log into QA CX
            driver.Navigate().GoToUrl("https://qa.conformx.com/");
            driver.FindElement(By.Id("txtUsername")).SendKeys("mttmadmin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("LotusElise57");
            driver.FindElement(By.XPath("//*[@id=\"divUserName\"]/a")).Click();

            //go to system administration tab then impersonation settings
            driver.FindElement(By.Id("ctl00_Header_lnkAdmin")).Click();
            driver.FindElement(By.Id("AdminLinks_lb4")).Click();
            driver.FindElement(By.XPath("//*[@id=\"AdminLinks_tbl_4\"]/tbody/tr[6]/td/a")).Click();

            //impersonate D400Admin
            driver.FindElement(By.Id("txtSearchUserToImpersonate")).SendKeys("D400Admin");
            driver.FindElement(By.Id("btnSearchUserToImpersonate")).Click();
            driver.FindElement(By.Id("dgUsersToImpersonate_ctl02_btnImpersonateWithRights")).Click();

            //go to system defaults page
            driver.FindElement(By.LinkText("System Default Settings")).Click();

            //go to eDisclose/eSign/eClose settings tab
            driver.FindElement(By.Id("systemDefaults_defaults_lb12")).Click();

            //change radio button for Enable eSign/eClose for FHA Loans to yes/no (change it)
            bool RadioValue = driver.FindElement(By.Id("systemDefaults_defaults_ctrlSetting400_0")).Selected;
            if(RadioValue)
            {
                driver.FindElement(By.Id("systemDefaults_defaults_ctrlSetting400_1")).Click();
            }
            else
            {
                driver.FindElement(By.Id("systemDefaults_defaults_ctrlSetting400_0")).Click();
            }

            //save
            driver.FindElement(By.Id("lbSave")).Click();

            //click second save if the pop up exists
            if(driver.FindElement(By.XPath("//*[@id=\"ConfirmSave\"]/div[2]/a[2]")).Displayed == true)
            {
                driver.FindElement(By.XPath("//*[@id=\"ConfirmSave\"]/div[2]/a[2]")).Click();
            }

            //stop impersonating D400
            driver.FindElement(By.Id("html_header_btnStopImpersonation")).Click();

            //close driver
            driver.Quit();

            








        }
    }
}
