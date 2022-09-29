using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Squares a number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>The input number squared</returns>
        /// <example> 
        /// GET api/square/2 ->
        /// 4
        /// </example>
        public int GET(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
