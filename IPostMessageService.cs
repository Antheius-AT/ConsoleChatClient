using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public interface IPostMessageService
    {
        Task<HttpResponseMessage> PostMessage(string postUri, string message);
    }
}
