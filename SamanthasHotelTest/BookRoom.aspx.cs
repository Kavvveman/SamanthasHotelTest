using SamanthasHotelTest.Dmbl;
using System;

namespace SamanthasHotelTest
{
    public partial class BookRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             var CurrentUser = new User();
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
                }
                if (FromDate != ToDate)
                {
                    DaysRoomisBooked = (ToDate.Date.Day - FromDate.Date.Day);
                    int RoomperDay = 120;
                    PriceOfBooking = Convert.ToInt32(DaysRoomisBooked) * RoomperDay;
                }
                else
                {
                    DaysRoomisBooked = 1;
                }
                using (DBInstDataContext _DBC = new DBInstDataContext())
                {
                    //User CurrentUser = new User();
                    _DBC.sp_InsertBooking(1, FromDate, ToDate, PriceOfBooking, true);
                }

                //Change to Insert into Bookings Table
                // Make instance of User Class
                PageNote.Visible = true;

                //PageNote.InnerText = "An " + cmbRoomType.SelectedValue.ToString() + " Room Has been successfully booked From " + FromDate + " To " + ToDate;
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