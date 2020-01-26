﻿using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public class ClickAddToCart : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath("//*[@id='add_to_cart']//button"));
        }
    }
}
