using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;

namespace Sesma.Application
{
    public class HelpServer
    {
        HttpListener _httpListener;
        private readonly string _address;
        private readonly int _port;
        
        public HelpServer(string address, int port)
        {
            _port = port;
            _address = address;
        }

        public void Start()
        {
            StartHttpListener();
            while (true)
                WaitForRequestThenHandle();
        }

        private void StartHttpListener()
        {
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(String.Format("http://{0}:{1}/", _address, _port));
            _httpListener.Start();
        }

        private void WaitForRequestThenHandle()
        {
            var incomingRequestContext = _httpListener.GetContext();

            ThreadPool.QueueUserWorkItem(state =>
            {
                try
                {
                    var context = state as HttpListenerContext;
                    var url = context.Request.Url;
                    var encoding = context.Request.ContentEncoding;
                    var page = url.AbsolutePath.Substring(1); // TODO UrlDecode

                    Respond(context, encoding, HelpPages.GetPage(page));
                }
                catch
                {
                    // nothing!
                }
            }, incomingRequestContext);
        }

        private static void Respond(HttpListenerContext context, Encoding encoding, string result)
        {
            var bytes = encoding.GetBytes(result);
            context.Response.ContentLength64 = bytes.Length;
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
            context.Response.StatusCode = 200; // everything is ok :)
            context.Response.Close();
        }
    }

}
