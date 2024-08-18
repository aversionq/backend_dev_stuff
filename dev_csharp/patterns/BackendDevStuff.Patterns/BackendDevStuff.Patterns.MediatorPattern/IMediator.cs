using BackendDevStuff.Patterns.MediatorPattern.Workers;

namespace BackendDevStuff.Patterns.MediatorPattern;

public interface IMediator
{
    void ProcessWork(AbstractWorker worker, string text);
}
