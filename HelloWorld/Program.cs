using System;
using System.Threading.Tasks;
using System.IO;
namespace Csharp8Features
{
    class AsynchronousDisposable
    {
        static async Task Main(string[] args)
        {
            await using (var disposableObject = new Sample())
            {
                Console.WriteLine("Welcome to C#.NET");
            }// DisposeAsync method called implicitly

            Console.WriteLine("Main Method End");
        }
    }

    public class Sample : IDisposable, IAsyncDisposable
    {
        private Stream? disposableResource = new MemoryStream();
        private Stream? asyncDisposableResource = new MemoryStream();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Dispose Clean-up the Memory!");
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore().ConfigureAwait(false);
            Dispose();
            GC.SuppressFinalize(this);
            Console.WriteLine("DisposeAsync Clean-up the Memory!");
        }

        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (asyncDisposableResource != null)
            {
                await asyncDisposableResource.DisposeAsync().ConfigureAwait(false);
            }

            if (disposableResource is IAsyncDisposable disposable)
            {
                await disposable.DisposeAsync().ConfigureAwait(false);
            }
            else
            {
                disposableResource?.Dispose();
            }

            asyncDisposableResource = null;
            disposableResource = null;

            Console.WriteLine("Virtual DisposeAsyncCore Clean-up the Memory");
        }
    }
}