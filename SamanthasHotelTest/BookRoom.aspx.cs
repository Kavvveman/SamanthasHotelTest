using SamanthasHotelTest.Dmbl;
using System;

namespace SamanthasHotelTest
{
    public partial class BookRoom : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            var User1 = new Dmbl.User();
            User1 = (Dmbl.User)Session["User"];
         
        }


        public static string CheckBookingIsValid(Booking booking)
        {
            return"";
        }

        public static string OverLappingBookingExists(Booking booking)
        {
            if (booking.IsActiveBooking == true)
            {

            }
            return "";
        }
        public static String OverlappingBookingExists()
        {
            return "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                double DaysRoomisBooked = 0;
                DateTime FromDate =Convert.ToDateTime(txtDateBookedFrom.Text);
                DateTime ToDate = Convert.ToDateTime(txtDateBookedTo.Text);

                int PriceOfBooking = 0;

                if (ToDate.Date < FromDate.Date)
                {
                    PageNote.Visible = true;
                    PageNote.InnerHtml = "Cannot book a Check In Time Earlier than a Check Out Time";
                    return;
                }
                if (FromDate != ToDate)
                {
                    DaysRoomisBooked = (ToDate.Date.Day - FromDate.Date.Day) + 1;
                    int RoomperDay = 120;
                    PriceOfBooking = Convert.ToInt32(DaysRoomisBooked) * RoomperDay;
                }
                else
                {
                    DaysRoomisBooked = 1;
                }
                DBInstDataContext _DBC = new DBInstDataContext();

                var User1 = new Dmbl.User();
                User1 = (Dmbl.User)Session["User"];

                //User CurrentUser = new User();
                _DBC.sp_InsertBooking(User1.UserId, FromDate, ToDate, PriceOfBooking, true);
                
                PageNote.Visible = true;
                txtBookingPrice.Visible = true;
                PageNote.InnerText = "Room Has been successfully booked From " + FromDate + " To " + ToDate +" By "+ User1.FirstName;
                txtBookingPrice.InnerText = PriceOfBooking.ToString();
            }
            catch (Exception ex)
            {
                PageNote.InnerHtml = "Error Has Occured " + ex.Message.ToString();
                // PageNote.InnerHtml= ("Error Has Occured +" ex.Message;
            }
        }

    }
}