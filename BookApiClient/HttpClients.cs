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
            //The approach below ensures that only one instance is created and only 
            //when the instance is needed. Also, the uniqueInstance variable is 
            //declared to be volatile to ensure that assignment to the instance variable 
            //completes before the instance variable can be accessed. Lastly, 
            //this approach uses a syncRoot instance to lock on, rather than 
            //locking on the type itself, to avoid deadlocks.

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
