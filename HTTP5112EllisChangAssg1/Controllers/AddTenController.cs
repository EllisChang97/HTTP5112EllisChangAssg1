using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds ten to a number
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The inputted number plus 10</returns>
        /// <example>
        /// GET: /api/addten/21 ->
        /// 31
        /// </example>
        public int Get(int id)
        {
            int add10 = id + 10;
            return add10;
        }


    }
}
