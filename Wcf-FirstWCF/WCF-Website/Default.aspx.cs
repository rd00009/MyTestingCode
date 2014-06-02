using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF_Website.ServiceReference1;
using WCF_Website.ServiceReference2;

namespace WCF_Website
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ser = new Service1Client();
            Label1.Text = ser.Endpoint.Address.Uri.AbsoluteUri.ToString();
            Label2.Text = ser.State.ToString();


            var ser2 = new ServiceReference2.AuthenticationClient();
            //ser2.DoWork();
        }
    }
}