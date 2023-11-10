// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.DevTools.V117.WebAuthn;
using NUnit.Framework;

IWebDriver driver=new ChromeDriver();
driver.Url="https://www.google.com";
string title = driver.Title;
Thread.Sleep(0000);
try
{
    Assert.AreEqual("Gooogle", title);
    Console.WriteLine("Pass");
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
driver.Close();