using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ServiceBus.Messaging;

namespace functionciapp
{
    public static class CITest
    {
        [FunctionName("CITestFunction")]
        public static void Run([ServiceBusTrigger("%testqueue%", AccessRights.Manage, Connection = "SBConnectionString")]BrokeredMessage myQueueItem, TraceWriter log)
        {
            log.Info($"NOEMI ROCKAR! C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}