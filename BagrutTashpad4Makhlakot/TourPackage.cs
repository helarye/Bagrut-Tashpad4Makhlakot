using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagrutTashpad4Makhlakot
{
    public class TourPackage
    {
        private int id;
        private int price;
        private int maxTime;
        private int maxData;
        private int extra;

        public TourPackage(int id, int price, int maxTime, int maxData)
        {
            this.id = id;
            this.price = price;
            this.maxTime = maxTime;
            this.maxData = maxData;
            this.extra = 0;
        }
        public void SetExtra(int minutes, int usage)
        //הפונקציה מקבלת את נפח השימוש בדטה ואת דקות השיחה ומחשבת את עלות החריגה
        {
            this.extra= minutes + usage*2;
        }
        public override string ToString()
        {
            string result="Package ditails for id:";
            result+=id.ToString();
            result+=" Price: "+ price+" Minutes:"+maxTime+" Data: "+maxData;
            result += " Extra Pay: " + this.extra;
            return result;
        }
        public int GetExtra() { return this.extra; }

    }
}
