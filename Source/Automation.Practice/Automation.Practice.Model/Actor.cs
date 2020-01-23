using Automation.Practice.WebDriver;

namespace Automation.Practice.Model
{
    public class Actor
    {
        private ActionHelpers _actionHelpers;
        public string Url { get => _actionHelpers.Url; }

        public Actor()
        {
            _actionHelpers = new ActionHelpers();
        }

        public Actor Can(IActorAction<ActionHelpers> ability)
        {
            ability.Execute(_actionHelpers);
            return this;
        }

        public Actor CleanUp()
        {
            _actionHelpers.Quit();
            return this;
        }
    }
}
