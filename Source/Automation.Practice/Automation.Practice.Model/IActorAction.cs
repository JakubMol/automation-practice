namespace Automation.Practice.Model
{
    public interface IActorAction<T>
    {
        void Execute(T ability);
    }
}
