using BackendDevStuff.Patterns.MediatorPattern.Workers;

namespace BackendDevStuff.Patterns.MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractWorker customer = new Customer();
            AbstractWorker programmer = new Programmer();
            AbstractWorker tester = new Tester();
            IMediator mediator = new SomeMediator(customer, programmer, tester);

            customer.Send("AVAVAV");
            tester.Send("kjkjkj");
            programmer.Send("ZAZAA");
        }
    }
}
