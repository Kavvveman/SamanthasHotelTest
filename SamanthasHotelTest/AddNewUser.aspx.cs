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
        private bool ValidInput()
        {



            return true;
        }

        Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {

                int i;
                if (!int.TryParse(txtName.Text.ToString(), out i))
                {
                    PageNoteAddUser.InnerText = "Name is a number only field";
                    return;
                };

                if (!int.TryParse(txtSurname.Text.ToString(), out i))
                {
                    PageNoteAddUser.InnerText = "Surname is a number only field";
                    return;
                }

                if (!emailRegex.IsMatch(txtEmail.Text.ToString()))
                {
                    PageNoteAddUser.InnerText = "That Email is Invalid";
                    return;
                }
                if (int.TryParse(txtCellNumber.Text.ToString(), out i))
                {
                    PageNoteAddUser.InnerText = "Cellnumber cannot contain characters";
                    return;
                }
                string FirstName = txtName.Text.ToString();
                string Surname = txtSurname.Text.ToString();
                string Email = txtEmail.Text.ToString();
                string Cellnum = txtCellNumber.Text.ToString();
                string IdNumber = txtIdNumber.Text.ToString();

                var postedResult = (inpAttachFile.PostedFile);
                var re = postedResult.InputStream;
                var re1 = postedResult.FileName;
                var re2 = postedResult.ContentType;
                var re3 = postedResult.InputStream;

                //--Hardcoded Until Can Get Image From FrontEnd
                //BinaryReader binaryReader = new BinaryReader(re3);

                int BinValue = 11125678;
                Binary bio = new Binary(new byte[BinValue]);
    

                using (DBInstDataContext _DBC = new DBInstDataContext())
                {
                    _DBC.sp_InsertUser(FirstName, Surname, Email, Cellnum, IdNumber, bio);
                }

                PageNoteAddUser.Visible = true;

                PageNoteAddUser.InnerText = "User " + FirstName + " Has Been Sucesssfully Added along with there details";


            }
            catch (Exception ex)
            {
                PageNoteAddUser.InnerHtml = "Error Has Occured " + ex.Message.ToString();

            }
        }
    }
}