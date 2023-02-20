using Microsoft.Ajax.Utilities;
using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SamanthasHotelTest
{
    public partial class CancelBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulateBookings();
            }
        }

        DBInstDataContext dbInstDataContext = new DBInstDataContext();  

        private void PopulateBookings()
         {
            DBInstDataContext ctx = new DBInstDataContext();
            gvBookings.DataSource = ctx.sp_SelectAllBookings();
            gvBookings.DataBind();
        }

        protected void gvBookings_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            if (!this.IsPostBack) { PopulateBookings(); }
        }

        List<Booking> bookings = new List<Booking>();


        protected void gvBookings_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            e.Keys.Remove(gvBookings.SelectedIndex);
            foreach (DataGridViewRow dvr in gvBookings.Rows)
            {
                if (dvr != null)
                {
                }
            }
            //Remove Booked room where BookingID matches Selected Row?
        }

        protected void gvBookings_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBInstDataContext ctx = new DBInstDataContext();
                int BookingID = Convert.ToInt32(gvBookings.DataKeys[e.RowIndex].Values[0]);
                ctx.sp_DeleteBooking(BookingID);//1000 covers for the auto indentity set to the column from sql
                ctx.SubmitChanges();
            }
        }


        protected void btnCancelBooking_Click(object sender, EventArgs e)
        {
            GridViewRow row = gvBookings.Rows[0];
        }

        protected void gvBookings_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {


                var BookingID = Int32.Parse((string)e.CommandArgument);
                DBInstDataContext ctx = new DBInstDataContext();



                ctx.sp_DeleteBooking(1000+ BookingID);
                //Delete from Database
                //Account for identity on databas

                gvBookings.DeleteRow(BookingID);
                //Delete from frontend
                ctx.SubmitChanges();
                PopulateBookings();
            }
        }
    }
}