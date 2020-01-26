using Automation.Practice.Constants;
using Automation.Practice.Model;
using Automation.Practice.Model.Common;
using Automation.Practice.Model.FeaturedClothes;
using Automation.Practice.Model.Register;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Automation.Practice.Test.SignIn.Step
{
    [Binding]
    public class CanSignInStep
    {
        private ScenarioContext _context;
        public CanSignInStep(ScenarioContext context)
        {
            _context = context;
        }
        [Given("I am on the landing page")]
        public void LandingPage()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new NavigateToLandingPage());
        }

        [When("I attempt to sign in")]
        public void AttemptToSignIn()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new ClickSignIn())
                .Can(new InputEmailCreate(newUser.Details.Email))
                .Can(new Register(newUser.Details))
                .Can(new ClickRegisterButton());
        }

        [Then("I can access the system")]
        public void CanAccessSystem()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            string expectedUrl = "http://automationpractice.com/index.php?controller=my-account";
            Assert.AreEqual(expectedUrl, newUser.Url); 
        }
    }
}
