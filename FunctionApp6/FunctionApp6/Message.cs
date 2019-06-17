using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace FunctionApp6
{
    public static class MessageFunction
    {
        [FunctionName("message")]
        public static async void Run([ServiceBusTrigger("QUEUE_NAME", Connection = "AzureWebJobsStorage")]string myQueueItem, [SignalR(HubName = "chat")]IAsyncCollector<SignalRMessage> signalRMessages, ILogger log)
        {

            if (string.IsNullOrEmpty(myQueueItem))
            {
                log.LogInformation("Please pass a payload to broadcast in the request body.");
                return ;
            }

            await signalRMessages.AddAsync(new SignalRMessage()
            {
                Target = "notify",
                Arguments = new object[] { myQueueItem }
            });

            log.LogInformation(myQueueItem);
            return;
        }
        
    }

}
