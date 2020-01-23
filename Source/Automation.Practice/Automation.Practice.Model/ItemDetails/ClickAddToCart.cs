using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public class SelectColor : IActorAction<ActionHelpers>
    {
        private readonly int _colorOrder;
        public SelectColor(int featuredOrder = 1)
        {
            _colorOrder = featuredOrder;
        }
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath($"//*[@id='color_to_pick_list']//li[{_colorOrder}]"));
        }
    }
}
