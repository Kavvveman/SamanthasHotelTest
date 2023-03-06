using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using User = SamanthasHotelTest.Dmbl.User;

namespace SamanthasHotelTest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //TestUser
        private User RetrieveUser(User user)
        {
            try
            {
                using (DBInstDataContext dbcon = new DBInstDataContext())
                {
                    var CurrentUser = from User u in dbcon.Users
                                      where
                                      u.FirstName == txtName.Text
                                      &&
                                      u.Password == txt.Text
                                      select u;
                }

                return user;
            }
            catch (Exception)
            {

                throw;
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get & Check users Password etc is valid
            var principal = new User();
            var CurrentUser = RetrieveUser(principal);

            if (CurrentUser != null)
            {
                Session session = new Session();
                session.SessionId = CurrentUser.UserId.ToString();  

                _Default def = new _Default();
                Server.Transfer(def.ToString());
            }

        }
    }
}