using coreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApp.Service
{
    public interface IlocationService
    {

        // public TimeTravelItems AddTimeTravelItems(TimeTravelItems items);

        locationItems AddLocationItems(locationItems items);

        Dictionary<string, locationItems> GetLocationItems();

        Dictionary<string, locationItems> GetDIstanceItems(double x , double y);

        


    }
}
