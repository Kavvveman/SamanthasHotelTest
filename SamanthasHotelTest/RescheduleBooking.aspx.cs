using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SamanthasHotelTest
{
    public partial class RescheduleBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulateBookings();
            }
        }
        DBInstDataContext ctx = new DBInstDataContext();

        private void PopulateBookings()
        {
            DBInstDataContext ctx = new DBInstDataContext();
            gvBookings.DataSource = ctx.sp_SelectAllBookings();
            gvBookings.DataBind();
        }
        protected void dgBookings_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            if (!this.IsPostBack) { PopulateBookings(); }
        }

        protected void dgBookings_EditCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void gvBookings_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvBookings_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBookings.EditIndex = e.NewEditIndex;

            DBInstDataContext ctx = new DBInstDataContext();
            //ctx.sp_UpdateRoom()
        }

        protected void gvBookings_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void gvBookings_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            //e.NewValues
            //e.OldValues.
            //gvBookings.EditIndex = e.KeepInEditMode;
            //DBInstDataContext ctx = new DBInstDataContext();
            //txtNote.InnerText = "Record Updated successfully";
            //PopulateBookings();
            //Session

        }

        protected void gvBookings_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gvBookings_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                editModal.Visible = true;

                DBInstDataContext ctx = new DBInstDataContext();

                Booking NewData = new Booking();
                if (gvBookings.SelectedRow.Cells[1] != null)
                {

                }
                NewData.BookingID = Convert.ToInt32(gvBookings.SelectedRow.Cells[1].Text);
                NewData.DateReservedFrom = Convert.ToDateTime(gvBookings.SelectedRow.Cells[4].Text);
                NewData.DateReservedTo = Convert.ToDateTime(gvBookings.SelectedRow.Cells[5].Text);



                ctx.sp_UpdateRoom1(NewData.BookingID, NewData.DateReservedFrom, NewData.DateReservedTo, DateTime.Now);

                ctx.SubmitChanges();
                PopulateBookings();
                //  ctx
                //Get and Update the value clicked on

            }
            if (e.CommandName == "Cancel")
            {

            }
        }
        protected void btnSaveChanges_Click(object sender, EventArgs e) 
        {
            Booking NewData = new Booking();
            txtBookingID.Text = (gvBookings.SelectedRow.Cells[1].Text).ToString();


            NewData.DateReservedFrom = Convert.ToDateTime(gvBookings.SelectedRow.Cells[4].Text);
            NewData.DateReservedFrom = Convert.ToDateTime(gvBookings.SelectedRow.Cells[4].Text);
            NewData.DateReservedTo = Convert.ToDateTime(gvBookings.SelectedRow.Cells[5].Text);
        }
    }
    
}