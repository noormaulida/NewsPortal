using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using NewsPortal.Model;
using System.Collections.Generic;


namespace NewsPortal.Controller
{
    public class MainPageController : ControllerBase
    {
        public MainPageController() {
            LoadData();
        }

        public void LoadData()
        {
            var client = new RestClient("http://api.nytimes.com");
            client.ClearHandlers();
            var request = new RestRequest("{a}/{b}/{c}/{d}/{e}/{f}");
            request.AddUrlSegment("a", "svc");
            request.AddUrlSegment("b", "mostpopular");
            request.AddUrlSegment("c", "v2");
            request.AddUrlSegment("d", "mostviewed");
            request.AddUrlSegment("e", "all-sections");
            request.AddUrlSegment("f", "1.json");

            request.AddParameter("api-key", "536306de3cfe2283df9c091afea40e82:9:67546031");
            request.RequestFormat = DataFormat.Json;

            try
            {
                var asyncHandle = client.ExecuteAsync(request, response =>
                {
                    if (response.ResponseStatus == ResponseStatus.Completed)
                    {
                        UpdateArticleList(response.Content);
                        MessageBox.Show(response.Content);
                    }
                    else
                        MessageBox.Show("Tidak dapat terhubung ke server");
                });
            }
            catch {
                MessageBox.Show("Eksekusi Gagal");
            
            }
        
        }

        public void UpdateArticleList(string content)
        {
            List<Article> listProduct = new List<Article>();
            Result hasil = new Result();

            hasil = JsonConvert.DeserializeObject<Result>(content);
            listProduct = hasil.Results;
            ListItemsSource = listProduct;
        }

        private IList<Article> _listItemsSource;

        public IList<Article> ListItemsSource
        {
            get
            {
                return _listItemsSource;
            }
            set
            {
                if (_listItemsSource != value)
                {
                    _listItemsSource = value;
                }

                OnPropertyChanged("ListItemsSource");
            }
        }

        private Article _listSelectedItem = null;

        public Article ListSelectedItem
        {
            get
            {
                return _listSelectedItem;
            }
            set
            {
                if (_listSelectedItem != value)
                {
                    _listSelectedItem = value;
                }

                OnPropertyChanged("ListSelectedItem");
            }
        }


    }
}
