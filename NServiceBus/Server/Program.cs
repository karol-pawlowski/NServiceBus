using System;
using NServiceBus;

class Program
{

    static void Main()
    {
        BusConfiguration busConfiguration = new BusConfiguration();
        busConfiguration.EndpointName("Samples.StepByStep.Server");
        busConfiguration.UseSerialization<JsonSerializer>();
        /*
         * JSON
         * XML
         * Binary
         */

        busConfiguration.EnableInstallers();
        busConfiguration.UsePersistence<InMemoryPersistence>();
        
        /* 
         * InMemory
         * MSMQ
         * RavenDB
         * NHibernate
         * Azure Storage
         */
        using (IBus bus = Bus.Create(busConfiguration).Start())
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
