using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApp.Models
{
    public class locationItems
    {
     
        public string ItemName { get; set; }

        public double x { set; get; }

        public double y { set; get; }

        public double x1 { set; get; }

        public double y1 { set; get; }

        public  IList<double> Start { get {
                var item = new List<double>();
                item.Add(x);
                item.Add(y);
                return item;
            } }

        public  IList<double> End { get {
                var item = new List<double>();
                item.Add(y);
                item.Add(y1);
                return item;
            } }

        public double Distance { get; set; }


    }
}
