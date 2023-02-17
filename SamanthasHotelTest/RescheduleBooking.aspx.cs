using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            DBInstDataContext ctx = new DBInstDataContext();
            txtNote.InnerText = "Record Updated successfully";
            PopulateBookings();
          
        }

        protected void gvBookings_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            txtNote.InnerText = "Record Updated successfully";
        }
    }
    
}