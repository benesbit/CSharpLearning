using System;
using System.Threading.Tasks;

namespace rest_tutorial
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
            // Console.WriteLine("Hello World!");
        }
        private static async Task ProcessRepositories()
        {

        }
    }
}
