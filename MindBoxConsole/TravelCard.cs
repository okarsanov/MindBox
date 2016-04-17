using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxConsole
{
    public class TravelCard
    {
        private String startPoint;
        private String endPoint;

        public TravelCard()
        {
            startPoint = String.Empty;
            endPoint = String.Empty;
        }

        public TravelCard(String start, String end)
        {
            startPoint = start;
            endPoint = end;
        }

        public String Start
        {
            get
            {
                return startPoint;
            }
        }

        public String End
        {
            get
            {
                return endPoint;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}->{1}", startPoint, endPoint);
        }
    }
}
