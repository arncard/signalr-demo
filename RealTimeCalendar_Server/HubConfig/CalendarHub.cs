using Microsoft.AspNetCore.SignalR;
using RealTimeCalendar_Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeCalendar_Server.HubConfig
{
    public class CalendarHub : Hub
    {
        // hub endpoint to invoke from the client, receiving the message
        public async Task BroadcastCalendarData(List<SchedulerEvent> data)
        {
            CalendarData.calendarDataList = data;
            // broadcast the message to all the clients listening to the
            // broadcastcalendardata event
            await Clients.All.SendAsync("broadcastcalendardata", data);
        }            
    }
}
