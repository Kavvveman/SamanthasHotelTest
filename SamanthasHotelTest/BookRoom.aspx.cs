using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SamanthasHotelTest
{
    public partial class BookRoom : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                double DaysRoomisBooked = 0;
                DateTime FromDate = Convert.ToDateTime(dtpDateBookedFrom.Value);
                DateTime ToDate = Convert.ToDateTime(dtpDateBookedTo.Value);
                string RoomType = cmbRoomType.SelectedValue;

                if (FromDate != ToDate)
                {
                    DaysRoomisBooked = (ToDate - FromDate).TotalDays;
                    double PriceOfBooking = (DaysRoomisBooked * 120);
                }
                else
                {
                    DaysRoomisBooked = 1;
                }
                using (DBInstDataContext _DBC = new DBInstDataContext())
                {
                    User CurrentUser = new User();
                    _DBC.sp_InsertBooking(CurrentUser.UserID, CurrentUser.Name, FromDate, ToDate, true);
                }

                //Change to Insert into Bookings Table
                // Make instance of User Class


                PageNote.Visible= true;

                PageNote.InnerText = cmbRoomType.SelectedValue.ToString() + "Room Has been successfully booked by ";
            }
            catch (Exception ex)
            {
                PageNote.InnerHtml = "Error Has Occured " + ex.Message.ToString();
                // PageNote.InnerHtml= ("Error Has Occured +" ex.Message;
                //throw;
            }
        }
        
    }
}