using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Challenge
{
    public class PostMessageService : IPostMessageService
    {
        private HttpClient client;
        private ILogger<PostMessageService> logger;

        public PostMessageService(ILogger<PostMessageService> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Posts a message to a specified endpoint.
        /// </summary>
        /// <param name="postUri">The specified endpoint for the post request.</param>
        /// <param name="message">The specified message that is to be sent.</param>
        /// <returns>A response message indicating the success status of the request.</returns>
        public async Task<HttpResponseMessage> PostMessage(string postUri, string message)
        {
            this.client = new HttpClient();
            var studentMessage = new StudentMessage("Gregor Faiman", message);
            this.logger.LogInformation($"Message {message} was successfully sent.");
            
            return await this.client.PostAsJsonAsync<StudentMessage>(postUri, studentMessage);
        }
    }
}
