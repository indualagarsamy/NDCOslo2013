using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NdcOslo.CustomerRelations.Messages.Events;
using NServiceBus;

namespace NdcOslo.CustomerRelations
{
    public class Bootstrapper : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }
        public void Start()
        {
            Console.WriteLine("Press something to publish an event");
            while (Console.ReadLine() != null)
            {
                var clientId = Guid.NewGuid();
                Bus.Publish<ClientBecamePreferred>(m => { m.ClientId = clientId; });
                Console.WriteLine("Client {0} became preferred", clientId);
            }
        }

        public void Stop()
        {

        }
    }
}
