using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using NewsPortal.Model;

namespace NewsPortal
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void lbArticle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Article temp = (Article)lbArticle.SelectedItem;
            //MessageBox.Show(temp.Id);
            if (temp != null)
            {
                //Navigation.ProductId = temp.Id;
                NavigationService.Navigate(new Uri("/View/MainPage.xaml", UriKind.Relative));
            }
        }
    }
}