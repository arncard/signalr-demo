using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeCalendar_Server.DataStorage;
using RealTimeCalendar_Server.HubConfig;

namespace RealTimeCalendar_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly IHubContext<CalendarHub> _hub;

        public CalendarController(IHubContext<CalendarHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            //transfer data to all the clients subscribed to the transfercalendardata event
            _hub.Clients.All.SendAsync("transfercalendardata", DataManager.GetCalendarData());

            return Ok(new { Message = "Request Completed" });
        }
    }
}
