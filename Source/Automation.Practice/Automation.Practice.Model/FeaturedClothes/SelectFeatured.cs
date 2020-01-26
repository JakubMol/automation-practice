using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.FeaturedClothes
{
    public class SelectFeatured : IActorAction<ActionHelpers>
    {
        private readonly int _featuredOrder;
        public SelectFeatured(int featuredOrder = 1)
        {
            _featuredOrder = featuredOrder;
        }
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath($"//*[@id='homefeatured']//li[{_featuredOrder}]//*[@itemprop='name']"));
        }
    }
}
