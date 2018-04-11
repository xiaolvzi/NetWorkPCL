using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetWorkPCL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            goInternet();
        }

        private async void goInternet()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            try
            {
                var details = await client.GetStringAsync("http://api.josephricklefs.com/api/currentraceinfo");
                System.Diagnostics.Debug.Write("11111111111111111"+details);

            }
            catch (Exception e)
            {
                // When Android set as Start Project always end up here 
                var ooo = e;
                throw;
            }
        }
    }
}
