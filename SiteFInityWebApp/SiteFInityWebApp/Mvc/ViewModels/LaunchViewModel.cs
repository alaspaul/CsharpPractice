using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Publishing.Web.Services.Data;

namespace SiteFInityWebApp.Mvc.ViewModels
{
    public class LaunchViewModel
    {
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }


        [JsonProperty(PropertyName = "mission_name")]
        public string MissionName { get; set; }
    }
}