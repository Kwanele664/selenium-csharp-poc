﻿namespace Selenium.Poc.PageObjects;

public class LandingPage : BasePage
{
    private readonly IWebDriver _driver;

    public LandingPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }
    
    private static By ProductLabel => By.ClassName("title");

    public string GetProductText()
    {
        return  GetText(ProductLabel);
    }
}