using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;


namespace NewsPortal.Model
{
    public class MediaMetadata {
        public string url { get; set; }
        public string format { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Media
    {
        public string type { get; set; }
        public string subtype { get; set; }
        public string caption { get; set; }
        public string copyright { get; set; }
        [JsonProperty(PropertyName = "media-metadata")]
        public List<MediaMetadata> Media_Metadata { get; set; }
    }
}
