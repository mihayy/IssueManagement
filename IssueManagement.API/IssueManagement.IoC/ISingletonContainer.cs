using Castle.Windsor;

namespace IssueManagement.IoC
{
    public interface ISingletonContainer
    {
        IWindsorContainer GetContainer { get; }
        void Initialize(IWindsorContainer container);
    }
}
