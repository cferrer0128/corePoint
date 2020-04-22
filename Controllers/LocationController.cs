using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreWebApp.Models;
using coreWebApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private IlocationService _services;

        public LocationController(IlocationService service)
        {
            _services = service;
        }
        [HttpPost]
        [Route("AddLocation")]
        public ActionResult<locationItems> AddTimeTravelItems(locationItems items)
        {
            var locationItems = _services.AddLocationItems(items);
            if (locationItems == null) return NotFound();
            return locationItems;
        }

        [HttpGet]
        [Route("GetLocationItems")]
        public ActionResult<Dictionary<string, locationItems>> GetLocationItems()
        {
            var locationItems = _services.GetLocationItems();

            if (locationItems.Count == 0) return NotFound();
            return locationItems;
        }

        [HttpGet]
        [Route("GetClosest/{x}/{y}")]
        public ActionResult<Dictionary<string, locationItems>> GetClosest(double x , double y)
        {
            _services.GetDIstanceItems(x,y);

            return _services.GetDIstanceItems(x, y);
        }

       
    }
}
