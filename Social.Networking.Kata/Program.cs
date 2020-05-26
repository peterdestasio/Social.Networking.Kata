using Ninject;
using System;
using System.Reflection;

namespace Social.Networking.Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StandardKernel kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());
                var startup = kernel.Get<IStartup>();
                startup.Run();
            }
            catch (Exception e)
            {
                if (e.Message != null)
                {
                    Console.WriteLine($"Error:\n{e.Message }\n");
                }

            }

        }
    }
}
