using CliWrap;
using System;
using System.Threading.Tasks;

namespace Repro.Tool
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            await Cli.Wrap("calc.exe").ExecuteAsync();
        }
    }
}