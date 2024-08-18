using BackendDevStuff.Patterns.MediatorPattern.Workers;

namespace BackendDevStuff.Patterns.MediatorPattern;

internal class SomeMediator : IMediator
{
    private readonly AbstractWorker _customer;
    private readonly AbstractWorker _programmer;
    private readonly AbstractWorker _tester;

    public SomeMediator(
        AbstractWorker customer,
        AbstractWorker programmer,
        AbstractWorker tester)
    {
        _customer = customer;
        _customer.SetMediator(this);
        _programmer = programmer;
        _programmer.SetMediator(this);
        _tester = tester;
        _tester.SetMediator(this);
    }

    public void ProcessWork(AbstractWorker worker, string text)
    {
        if (worker is Customer)
        {
            _customer.Notify(text);
        }
        if (worker is Programmer)
        {
            _programmer.Notify(text);
        }
        if (worker is Tester)
        {
            _tester.Notify(text);
        }
    }
}
