using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public class ClickProceedToCheckout : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath($"//*[@id='layer_cart']//*[@title='Proceed to checkout']"));          
        }
    }
}
