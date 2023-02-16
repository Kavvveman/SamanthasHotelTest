using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;
using WebGrease.Css.Ast;

namespace SamanthasHotelTest
{
    public partial class AddNewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmitBooking_Click(object sender, EventArgs e)
        {
            try
            {
                //validation done here?
                //string EmailRegexValidation = "@\"^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$\"";
                //if (Regex.Matches(txtEmail.Text.ToString(), EmailRegexValidation)
                //{

                //}
                string FirstName = txtName.Text.ToString();
                string Surname = txtSurname.Text.ToString();
                string Email = txtEmail.Text.ToString();
                string Cellnum = txtCellNumber.Text.ToString();
                string IdNumber = txtIdNumber.Text.ToString();
                var postedResult = (inpAttachFile.PostedFile);
                var re = postedResult.InputStream;
                var re1 = postedResult.FileName;
                var re2 = postedResult.ContentType;
                var re3 = postedResult.ContentLength;
                // re.Read();
                //Find params and Pass to here
                //FileStream F = new FileStream();
                //Binary UserImg = (Binary)inpAttachFile.PostedFile.InputStream;

                //Capture Variables
                //Call Db Context

                //--Hardcoded Until Can Get Image From FrontEnd


                int BinValue = 11125678;
                Binary bio = new Binary(new byte[BinValue]);
                //BinaryReader binary = 

                DBInstDataContext _DBC = new DBInstDataContext();
                _DBC.sp_InsertUser(FirstName, Surname, Email, Cellnum, IdNumber, bio);
                PageNoteAddUser.InnerText = "User " + FirstName + "Has Been Sucesssfully Added along with there details"

            }
            catch (Exception ex)
            {
                PageNoteAddUser.InnerHtml = "Error Has Occured " + ex.Message.ToString();
                throw;
            }
      
        }

        //Method for Image?
    }
}