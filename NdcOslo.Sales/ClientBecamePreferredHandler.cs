using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NdcOslo.CustomerRelations.Messages.Events;
using NServiceBus;

namespace NdcOslo.Sales
{
    public class ClientBecamePreferredHandler : IHandleMessages<ClientBecamePreferred>
    {
        public void Handle(ClientBecamePreferred message)
        {
            Console.WriteLine("Hey client {0} is now preferred...", message.ClientId);
        }
    }
}
