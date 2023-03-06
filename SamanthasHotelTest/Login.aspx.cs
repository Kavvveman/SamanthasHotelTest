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
        // public User _currentUser = new User();
         // var principal = new User();
         }

        //TestUser
        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //}
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



            //HttpContext.sess
            //public void OnGet()
            //{
            //    if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
            //    {
            //        HttpContext.Session.SetString(SessionKeyName, "The Doctor");
            //        HttpContext.Session.SetInt32(SessionKeyAge, 73);
            //    }
            //    var name = HttpContext.Session.GetString(SessionKeyName);
            //    var age = HttpContext.Session.GetInt32(SessionKeyAge).ToString();

            //    _logger.LogInformation("Session Name: {Name}", name);
            //    _logger.LogInformation("Session Age: {Age}", age);
            //}

        }
    }
}