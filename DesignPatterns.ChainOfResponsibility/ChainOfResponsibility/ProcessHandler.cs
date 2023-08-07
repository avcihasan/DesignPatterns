namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class ProcessHandler: IProcessHandler
    {
        IProcessHandler _nextProcessHandler;
        public virtual object Handler(object o, Type T)
        {
            if (_nextProcessHandler is not null)
                return _nextProcessHandler.Handler(o, T);
            return null;
        }

        public IProcessHandler SetNext(IProcessHandler processHandler)
        {
            _nextProcessHandler = processHandler;
            return _nextProcessHandler;
        }
    }
}
