namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public interface IProcessHandler
    {
        IProcessHandler SetNext(IProcessHandler processHandler);
        Object Handler(Object o, Type T);
    }
}
