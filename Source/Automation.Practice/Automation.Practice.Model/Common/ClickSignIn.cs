﻿using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Common
{
    public class ClickSignIn : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath("//*[@title='Log in to your customer account']"));
        }
    }
}
