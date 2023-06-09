using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SamanthasHotelTest
{
    public partial class CancelBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulateBooking();
            }
        }

        DBInstDataContext dbInstDataContext = new DBInstDataContext();

        private void PopulateBooking()
        {
            try
            {
                DBInstDataContext ctx = new DBInstDataContext();
                gvBooking.DataSource = ctx.sp_SelectAllBookings();
                gvBooking.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void gvBooking_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            if (!this.IsPostBack) { PopulateBooking(); }
        }

        List<Booking> Booking = new List<Booking>();


        protected void gvBooking_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            try
            {
                e.Keys.Remove(gvBooking.SelectedIndex);
                foreach (DataGridViewRow dvr in gvBooking.Rows)
                {
                    if (dvr != null)
                    {
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void gvBooking_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    DBInstDataContext ctx = new DBInstDataContext();
                    int BookingID = Convert.ToInt32(gvBooking.DataKeys[e.RowIndex].Values[0]);
                    ctx.sp_DeleteBooking(BookingID);//1000 covers for the auto indentity set to the column from sql
                    ctx.SubmitChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        protected void btnCancelBooking_Click(object sender, EventArgs e)
        {
            GridViewRow row = gvBooking.Rows[0];
        }

        protected void gvBooking_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Delete")
                {
                    var BookingID = Int32.Parse((string)e.CommandArgument);
                    DBInstDataContext ctx = new DBInstDataContext();

                    ctx.sp_DeleteBooking(BookingID);

                    // ctx.sp_DeleteBooking(1000 + BookingID);
                    //Delete from Database
                    //Account for identity on databas

                    gvBooking.DeleteRow(BookingID);
                    //Delete from frontend
                    ctx.SubmitChanges();
                    PopulateBooking();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}