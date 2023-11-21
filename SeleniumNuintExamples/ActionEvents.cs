using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNuintExamples
{
    internal class ActionEvents:CoreCodes
    {
        [Test]
        public void HomeLinkTest()
        {
            IWebElement homelink = driver.FindElement(By.LinkText("Home"));
            IWebElement tdHome = driver.FindElement(By.XPath('/html/body/div[2]/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[1]/td[1]');
        }
        


    }
}
