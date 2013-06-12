using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace NdcOslo.CustomerRelations
{
    class MessageConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            NServiceBus.Configure.Instance.DefiningEventsAs(m => m.Namespace != null 
                && m.Namespace.EndsWith("Events"));
        }
    }
}
