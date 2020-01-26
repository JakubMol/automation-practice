using Automation.Practice.Constants;
using Automation.Practice.Model;
using Automation.Practice.Model.FeaturedClothes;
using Automation.Practice.Model.ItemDetails;
using Automation.Practice.Model.Register;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Automation.Practice.Test.CanBuyItem.Step
{
    [Binding]
    public class CanBuyItem
    {
        private ScenarioContext _context;
        public CanBuyItem(ScenarioContext context)
        {
            _context = context;
        }
        [Given("I have selected and item")]
        public void SelectedItem()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new NavigateToLandingPage())
                .Can(new SelectFeatured());
        }

        [Given("changed the color")]
        public void ChangeColor()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new SelectColor(2));
        }

        [Given("changed size")]
        public void ChangeSize()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new SelectSize(Size.S));
        }

        [Given("changed quantity")]
        public void ChangeQuantity()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new InputQuantity(2));
        }

        [When("I attempt to buy it")]
        public void AttemptToBuy()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new ClickAddToCart())
                .Can(new ClickProceedToCheckout())
                .Can(new InputEmailCreate(newUser.Details.Email))
                .Can(new Register(newUser.Details))
                .Can(new ClickRegisterButton());
        }

        [Then("I should be able to checkout")]
        public void Checkout()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            string expectedUrl = "http://automationpractice.com/index.php?controller=my-account";
            Assert.AreEqual(expectedUrl, newUser.Url);
        }
    }
}
