using SamanthasHotelTest.Dmbl;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SamanthasHotelTest
{
    public partial class AddNewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, User _CurUser)
        {
            
        }


        Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?
                                ^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+
                                [a-z0-9](?:[a-z0-9-]*[a-z0-9])?");



        private void ValidInput()
        {
            int i;
            if (!int.TryParse(txtName.Text.ToString(), out i))
            {
                PageNoteAddUser.InnerText = "Name is a number only field";
            };

            if (!int.TryParse(txtSurname.Text.ToString(), out i))
            {
                PageNoteAddUser.InnerText = "Surname is a number only field";
            }

            if (!emailRegex.IsMatch(txtEmail.Text.ToString()))
            {
                PageNoteAddUser.InnerText = "That Email is Invalid";
            }
            if (int.TryParse(txtCellNumber.Text.ToString(), out i))
            {
                PageNoteAddUser.InnerText = "Cellnumber cannot contain characters";
            }

        }



        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = txtName.Text.ToString();
                string Surname = txtSurname.Text.ToString();
                string Email = txtEmail.Text.ToString();
                string Cellnum = txtCellNumber.Text.ToString();
                string IdNumber = txtIdNumber.Text.ToString();
                string Password = txtPassword.Text.ToString();  


                var postedResult = (inpAttachFile.PostedFile);
                var re = postedResult.InputStream;
                var re1 = postedResult.FileName;
                var re2 = postedResult.ContentType;

                using (DBInstDataContext _DBC = new DBInstDataContext())
                {
                    Byte[] Content = new BinaryReader(postedResult.InputStream).ReadBytes(postedResult.ContentLength);
                    _DBC.sp_InsertUser(
                        FirstName,
                        Surname, 
                        Email,
                        Cellnum, 
                        IdNumber, 
                        Content, 
                        Password);
                }

                PageNoteAddUser.Visible = true;

                PageNoteAddUser.InnerText = "User " + FirstName + " Has Been Sucesssfully Added along with there details and photo";
                ClearForm();

            }
            catch (Exception ex)
            {
                PageNoteAddUser.InnerHtml = "Error Has Occured " + ex.Message.ToString();

            }
        }
        private void ClearForm()
        {
            txtCellNumber.Text = string.Empty;
            txtIdNumber.Text = string.Empty;    
            txtPassword.Text = string.Empty;    
            txtEmail.Text = string.Empty;       
            txtIdNumber.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}