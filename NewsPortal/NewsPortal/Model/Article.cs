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

namespace NewsPortal.Model
{
    public class Article
    {
        public string url { get; set; }
        public string adx_keywords { get; set; }
        public string column { get; set; }
        public string section { get; set; }
        public string byline { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string Abstract { get; set; }
        public string published_date { get; set; }
        public string source { get; set; }
        public object id { get; set; }
        public double asset_id { get; set; }
        public int views { get; set; }
        public object des_facet { get; set; }
        public object org_facet { get; set; }
        public object per_facet { get; set; }
        public object geo_facet { get; set; }
        public object Media { get; set; }

    }
}
