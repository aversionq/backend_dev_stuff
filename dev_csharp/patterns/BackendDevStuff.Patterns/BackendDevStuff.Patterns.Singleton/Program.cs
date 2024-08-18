namespace BackendDevStuff.Patterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = SingletonClass.GetInstance();
            var singleton2 = SingletonClass.GetInstance();

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());

            Console.WriteLine(singleton1.Equals(singleton2));
            Console.WriteLine(ReferenceEquals(singleton1, singleton2));
        }
    }
}
