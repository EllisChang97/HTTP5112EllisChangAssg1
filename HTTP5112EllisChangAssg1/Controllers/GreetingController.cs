using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// Returns the message "Hello World!"
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST /api/Greeting -> 
        /// "Hello World"
        /// </example>

        public string Post()
        {
            return "Hello World!";
        }




        /// <summary>
        /// Will greet a certain number of people 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Greets the certain number of people inputted</returns>
        /// <example>
        /// GET: /api/greeting/5 ->
        /// "Greetings to 5 people"
        /// </example>

        public string Get(int id)
        {
            string greeting = "Greetings to " + id + " people";
            return greeting;
        }
    }
}
