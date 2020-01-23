using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public class InputQuantity : IActorAction<ActionHelpers>
    {
        private readonly int _qantity;
        public InputQuantity(int quantity = 1)
        {
            _qantity = quantity;
        }
        public void Execute(ActionHelpers helpers)
        {
            helpers.SendKeys(By.Id("quantity_wanted"), _qantity.ToString());
        }
    }
}
