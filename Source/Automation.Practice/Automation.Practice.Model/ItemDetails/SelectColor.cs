using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public class ClickAddToCart : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.Id("add_to_cart"));
        }
    }
}
