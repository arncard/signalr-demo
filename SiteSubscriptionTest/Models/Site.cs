using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteSubscriptionTest.Models
{
    public class Site
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string EventName { get; set; }
    }

    public class SiteList
    {
        public List<Site> sites { get; set; }

        public SiteList()
        {
            sites = new List<Site>();
        }
    }
}
