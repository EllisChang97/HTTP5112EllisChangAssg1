using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Puts a number through a number machine
        /// </summary>
        /// <return>The inputted number plus 2, then multiplied by 4, then divided by 2, then subtranced by 1</return>
        /// <param name="id"></param>
        /// <example>
        /// GET: /api/numbermachine/2 ->
        /// 7
        /// </example>
        public int get(int id)
        {
            int NumberMachine = (((id + 2) * 4) / 2) - 1;
            return NumberMachine;
        }
    }
}
