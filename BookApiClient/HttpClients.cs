using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookApiClient
{
    // a one-time initializer | create an instance of the class and share it through a static member. 
    class HttpClients
    {
        private volatile static HttpClient uniqueInstance;
        private static object syncRoot = new Object();

        private HttpClients()
        { }

        public static HttpClient GetInstance()
        {
       
            if (uniqueInstance == null)
            {
                lock (syncRoot)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new HttpClient();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}
