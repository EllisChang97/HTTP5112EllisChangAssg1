using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112EllisChangAssg1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Tells the customer how much they owe for hosting 
        /// </summary>
        /// <return>
        /// A statement of how many fortnights the user needs to pay for 
        /// and how much it costs, a statement of the tax that is owed, 
        /// a statement of the total owed
        /// </return>
        /// <example>
        /// GET /api/hostingcost/14 ->
        /// “2 fortnights at $5.50/FN = $11.00 CAD”
        ///“HST 13% = $1.43 CAD”
        ///“Total = $12.43 CAD”
        /// </example>

        public IEnumerable<string> GET(int id)
        {

            if (id % 14 == 0)
            {
                int hostTimeDaysEven = id + 1;
                decimal hostTimeFortnightsEven = Math.Ceiling(hostTimeDaysEven / 14m);
                decimal beforeTaxEven = hostTimeFortnightsEven * 5.50m;
                decimal taxEven = Math.Round(beforeTaxEven * 0.13m, 2);
                decimal totalEven = Math.Round(beforeTaxEven + taxEven, 2);
                IEnumerable<string> CostEven = new string[] {
                hostTimeFortnightsEven.ToString() + " fortnights at $5.50/FN = "  + beforeTaxEven.ToString(),
                "HST 13% = $" + taxEven.ToString(),
                "Total = $" + totalEven.ToString() + " CAD" };

                return CostEven;
            }
            int hostTimeDays = id;
            decimal hostTimeFortnights = Math.Ceiling(id / 14m);
            decimal beforeTax = hostTimeFortnights * 5.50m;
            decimal tax = Math.Round(beforeTax * 0.13m, 2);
            decimal total = Math.Round(beforeTax + tax, 2);
            IEnumerable<string> Cost = new string[] {
            hostTimeFortnights.ToString() + " fortnights at $5.50/FN = "  + beforeTax.ToString(),
            "HST 13% = $" + tax.ToString(),
            "Total = $" + total.ToString() + " CAD" };

            return Cost;
            }


            }
        }
    

