using Microsoft.Ajax.Utilities;
using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Providers.Entities;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using User = SamanthasHotelTest.Dmbl.User;

namespace SamanthasHotelTest
{

    public partial class Login : System.Web.UI.Page
    {
        public User _currentUser = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private User RetrieveUser(User user)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtName.Value) && !String.IsNullOrEmpty(txtPassword.Value))
                {
                    DBInstDataContext dbcon = new DBInstDataContext();

                    var CurrentUser = (from User u in dbcon.Users
                                       where
                                       u.FirstName == txtName.Value
                                       &&
                                       u.Password == txtPassword.Value
                                       select u).FirstOrDefault();


                    User user1 = user;
                    _currentUser.UserId = CurrentUser.UserId;
                    _currentUser.FirstName = CurrentUser.FirstName;
                    _currentUser.CellNumber = CurrentUser.CellNumber;
                    _currentUser.Password = CurrentUser.Password;
                    _currentUser.Email = CurrentUser.Email;
                    _currentUser.Idnumber = CurrentUser.Idnumber;
                    _currentUser.UserImage = CurrentUser.UserImage;

                }
                return user;
            }
            catch (Exception)
            {
                throw;
            }

        }
        protected void btnGo_Click(object sender, EventArgs e)
        {
            //Get & Check users Password etc is valid
            var principal = new User();
            RetrieveUser(principal);

            if (_currentUser != null)
            {
                Response.Redirect("Default.aspx?User=" + _currentUser);

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}