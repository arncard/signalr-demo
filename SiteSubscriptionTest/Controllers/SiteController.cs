using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SiteSubscriptionTest.DataStorage;
using SiteSubscriptionTest.HubConfig;
using SiteSubscriptionTest.TimerFeatures;

namespace SiteSubscriptionTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        private readonly IHubContext<SiteHub> _hub;

        public SiteController(IHubContext<SiteHub> hub)
        {
            _hub = hub;
        }

        public IActionResult Get()
        {
            //transfer data to all the clients subscribed to the transfercalendardata event
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("koalabeachevent", "TRANSFERRED MESSAGE FROM SERVER"));            
            return Ok(new { Message = "Request Completed" });            
        }

        [Route("send-message/{eventtosend}/{sitename}")]
        [HttpGet]
        public IActionResult SendMessage(string eventtosend, string sitename)
        {
            _hub.Clients.All.SendAsync(eventtosend, "Message sent to the site " + sitename);
            return Ok(new { Message = "Message Sent to the site " + sitename });
        }
    }
}
