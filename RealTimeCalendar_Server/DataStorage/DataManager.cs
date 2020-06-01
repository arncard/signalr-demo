using System;
using System.Collections.Generic;
using RealTimeCalendar_Server.Models;

namespace RealTimeCalendar_Server.DataStorage
{
    public static class DataManager
    {
        //public static List<ChartModel> GetData()
        //{
        //    var r = new Random();
        //    return new List<ChartModel>
        //    {
        //        new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data1" },
        //        new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data2" },
        //        new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data3" },
        //        new ChartModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data4" }
        //    };
        //}

        public static List<SchedulerEvent> GetCalendarData()
        {
            var tempList = new List<SchedulerEvent>() { new SchedulerEvent() { id = 100, title ="title from server",
                start = DateTime.Now, end = DateTime.Now.AddMinutes(30)} };
            return CalendarData.calendarDataList ?? tempList;           
        }
    }
}
public static class CalendarData
{ 
    public static List<SchedulerEvent> calendarDataList { get; set; }

    //public CalendarData()
    //{
    //    calendarData = new List<SchedulerEvent>();
    //}
}