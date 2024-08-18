namespace BackendDevStuff.Patterns.MediatorPattern.Workers;

public abstract class AbstractWorker
{
    protected IMediator _mediator;

    protected AbstractWorker()
    {
    }

    public virtual void Send(string text)
    {
        _mediator.ProcessWork(this, text);
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public abstract void Notify(string text);
}
