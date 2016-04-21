using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Web;

namespace SignalRDraw.Models
{
    public class Data
    {
        [JsonProperty("startX")]
        public int StartX { get; set; }
        [JsonProperty("startY")]
        public int StartY { get; set; }
        [JsonProperty("endX")]
        public int EndX { get; set; }
        [JsonProperty("endY")]
        public int EndY { get; set; }
    }
}