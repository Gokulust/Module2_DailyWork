// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.DevTools.V117.WebAuthn;
using NUnit.Framework;
using SeleniumExample;

GHPTests gHPTests=new GHPTests();
List<string> list = new List<string>();
list.Add("Edge");
list.Add("Chrome");
foreach (var item in list)
{
    switch (item)
    {
        case "Edge":
            gHPTests.InitializeEdgeDriver(); ;
            break;
        case "Chrome":
            gHPTests.InitializeChromeDriver();
            break;
    }
    try
    {
        gHPTests.TitleTest();
        //gHPTests.PageSourceTest();
        gHPTests.GSTest();
        gHPTests.GmaiLinkTest();
        gHPTests.ImagesLinkTest();
        gHPTests.LocalizationTest();


    }
    catch (AssertionException)
    {
        Console.WriteLine("Fail");
    }
}

gHPTests.Destruct();
