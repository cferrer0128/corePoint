using coreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApp.Service
{
    public class LocationServices : IlocationService
    {
        private readonly Dictionary<string, locationItems> _locationItems;

        private  Dictionary<string, locationItems> _distanceItems;

        private Dictionary<string, locationItems> _tmpItems; 

        public LocationServices()
        {
            _locationItems = new Dictionary<string, locationItems>();

        }

        public locationItems AddLocationItems(locationItems items)
        {
            try { _locationItems.Add(items.ItemName, items); return items; }
            catch { return null; }
           
        }

        private double dist(double x , double y , double x1, double y1)
        {
           
            double P1 = (x - x1);
            P1 *= P1;
            //for y
            double P2 = (y - y1);
            P2 *= P2;
            return Math.Sqrt((P1 + P2));

        }
        public Dictionary<string, locationItems> GetDIstanceItems(double x, double y)
        {
            _distanceItems = new Dictionary<string, locationItems>();
            _tmpItems = new Dictionary<string, locationItems>();

            if (_locationItems.Count > 0)
               foreach(KeyValuePair<string,locationItems> entry in _locationItems)
                {

                    var x1 = entry.Value.Start[0];

                    var y1 = entry.Value.Start[1];

                    var distance1 = dist(x, y, x1, y1);

                    var x2 = entry.Value.End[0];

                    var y2 = entry.Value.End[1];

                    var distance2 = dist(x, y, x2, y2);

                    entry.Value.Distance = distance1 > distance2 ? distance2 : distance1;

                    _tmpItems.Add(entry.Key, entry.Value);



                }

            var order = _tmpItems.OrderBy(o => o.Value.Distance);

            for(var i=0; i < order.Count(); i++)
            {
                var item = order.ElementAt(i);

                _distanceItems.Add(item.Key, item.Value);
            }
           

            return _distanceItems;



        }

        public Dictionary<string, locationItems> GetLocationItems()
        {
            return _locationItems;
        }
    }

}
