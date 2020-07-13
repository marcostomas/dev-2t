using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : IMasterDetailPageController
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
                 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;

        }
    }
}
