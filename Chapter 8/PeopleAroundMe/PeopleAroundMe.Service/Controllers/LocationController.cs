using System.Collections.Generic;
using System.Web.Http;

namespace PeopleAroundMe.Service.Controllers
{
    public class LocationController : ApiController
    {
        private static List<dynamic> peopleData = new List<dynamic>();

        public IEnumerable<dynamic> Get()
        {
            return peopleData;
        }

        public void Post(string fullName, double latitude, double longitude)
        {
            peopleData.Add(new { FullName = fullName, Latitude = latitude, Longitude = longitude });
        }
    }
}