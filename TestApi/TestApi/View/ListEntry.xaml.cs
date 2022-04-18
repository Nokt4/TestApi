using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntry : ContentPage
    {
        public ListEntry()
        {
            InitializeComponent();
            RestService restService = new RestService();
            var 
            pop.ItemsSource = 
        }
        
    }
}