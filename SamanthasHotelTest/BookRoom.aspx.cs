using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                DBInstDataContext _DBC = new DBInstDataContext();

                //Change to Insert into Bookings Table
                _DBC.sp
                _DBC.sp_InsertRoom(RoomType, FromDate, ToDate, DateTime.Now);

                PageNote.InnerHtml = "Room Has been successfully booked";
            }
            catch (Exception ex)
            {
                PageNote.InnerHtml = "Error Has Occured " + ex.Message.ToString();
                // PageNote.InnerHtml= ("Error Has Occured +" ex.Message;
                throw;
            }
        }
        
    }
}