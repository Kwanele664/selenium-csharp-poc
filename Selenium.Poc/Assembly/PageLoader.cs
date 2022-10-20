﻿using Selenium.Poc.PageObjects;

namespace Selenium.Poc.Assembly;
public class PageLoader
{
    private readonly IWebDriver _driver;

    public PageLoader(IWebDriver driver)
    {
        _driver = driver;
    }

    public LoginPage LoginPage => GetPage<LoginPage>(_driver);
    public LandingPage LandingPage => GetPage<LandingPage>(_driver);
    
    //Image reflection will create an instance on runtime.
    private static T GetPage<T>(IWebDriver driver) where T : class
    {
        return (T)Activator.CreateInstance(typeof(T), driver)! 
               ?? throw new InvalidOperationException();
    }
}