using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdcOslo.CustomerRelations.Messages.Events
{
    public class ClientBecamePreferred 
    {
        public Guid ClientId { get; set; }
    }
}
