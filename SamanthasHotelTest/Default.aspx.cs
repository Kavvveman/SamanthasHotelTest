using SamanthasHotelTest.Dmbl;
using System;
using System.Web.UI;
using System.Web.Providers.Entities;
using System.Web.SessionState;
using Microsoft.Ajax.Utilities;

namespace SamanthasHotelTest
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            var User1 = new Dmbl.User();
            User1 = (Dmbl.User)Session["User"];
            txtUser.InnerHtml = User1.FirstName;

        }
    }
}