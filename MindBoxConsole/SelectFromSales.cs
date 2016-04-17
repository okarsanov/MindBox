using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxConsole
{
    class SelectFromSales
    {
        private String select = "SELECT productid, COUNT (datetime1) AS FirstPurchase FROM Sales WHERE datetime1 IN (" +
	                                    "SELECT MIN(datetime1) as MinDateTime FROM Sales" + 
	                                    "GROUP BY customerid" +
                                ")GROUP BY productid";
    }
}
