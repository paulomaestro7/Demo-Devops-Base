using System;

namespace DevopsBase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
                Console.WriteLine("Vocês esta em Desenvolvimento!");

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Homologation")
                Console.WriteLine("Vocês esta em Homologação");

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                Console.WriteLine("Vocês esta em Produção");

            Console.Read();
        }
    }
}
