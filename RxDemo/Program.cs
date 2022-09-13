using System.Reactive.Linq;

namespace RxDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IObservable<long> xs = Observable
                .Timer(DateTimeOffset.Now.AddSeconds(1.5), TimeSpan.FromSeconds(0.5))
                .Where(x => x % 2 == 0)
                .Take(5);

            xs.Subscribe(x => Console.WriteLine(x));

            await new TaskCompletionSource<object>().Task;
        }
    }
}