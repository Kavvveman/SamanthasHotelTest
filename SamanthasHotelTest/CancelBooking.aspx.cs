using Microsoft.Ajax.Utilities;
using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                this.PopulateBookings();
            }
        }

        DBInstDataContext dbInstDataContext = new DBInstDataContext();  

        private void PopulateBookings()
        {
            BindingSource _source = new BindingSource();
            DBInstDataContext ctx = new DBInstDataContext();
            gvBookings.DataSource = ctx.sp_SelectAllBookings();
            gvBookings.DataBind();
        }

        protected void gvBookings_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (!this.IsPostBack) { PopulateBookings(); }
        }

        //List<Booking> bookings = new List<Booking>();
        //bookings = dbInstDataContext.sp


        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow dvr in dgLogList.SelectedRows)
        //    {
        //        if (dvr != null)
        //        {
        //            dgLogList.Rows.Remove(dvr);
        //            dgLogList.Refresh();
        //        }
        //    }
        //}

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
            GridViewRow row = gvBookings.Rows[e.RowIndex];

            int BookingID = Convert.ToInt32(gvBookings.DataKeys[e.RowIndex].Values[0]);

            var rowcntrl = row.Cells[0].Controls[0];

            

            e.Values.RemoveAt(gvBookings.SelectedIndex);

            PopulateBookings();
        }





        protected void btnCancelBooking_Click(object sender, EventArgs e)
        {
            GridViewRow row = gvBookings.Rows[0];
        }
    }
}