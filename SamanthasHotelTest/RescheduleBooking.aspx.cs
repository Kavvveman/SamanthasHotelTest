using SamanthasHotelTest.Dmbl;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SamanthasHotelTest
{
    public partial class RescheduleBooking : System.Web.UI.Page
    {
        WebSocket WebSocket = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.PopulateBooking();
            }
        }
        DBInstDataContext ctx = new DBInstDataContext();

        private void PopulateBooking()
        {
            DBInstDataContext ctx = new DBInstDataContext();
            gvBooking.DataSource = ctx.sp_SelectAllBookings();
            gvBooking.DataBind();
        }
        protected void dgBooking_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            if (!this.IsPostBack) { PopulateBooking(); }
        }

        protected void dgBooking_EditCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void gvBooking_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvBooking_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBooking.EditIndex = e.NewEditIndex;

            DBInstDataContext ctx = new DBInstDataContext();
            //ctx.sp_UpdateRoom()
        }

        protected void gvBooking_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
        protected void gvBooking_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            //e.NewValues
            //e.OldValues.
            //gvBooking.EditIndex = e.KeepInEditMode;
            //DBInstDataContext ctx = new DBInstDataContext();
            //txtNote.InnerText = "Record Updated successfully";
            //PopulateBooking();
            //Session

        }

        protected void gvBooking_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

         protected void gvBooking_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                editModal.Visible = true;

                DBInstDataContext ctx = new DBInstDataContext();

                Booking NewData = new Booking();

                //TextBox name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
                //TextBox city = GridView1.Rows[e.RowIndex].FindControl("txt_City") as TextBox;

               // TextBox name = gvBooking.Rows.[e.RowIndex].FindControl("txt_Name") as TextBox;

                //string unitprice = ((TextBox)e..Cells[3].Controls[0]).Text;
                //string txt = ((TextBox)(datagrid1.FindControl("Control1"))).Text;

               // int BookingID = Convert.ToInt32(gvBooking.DataKeys[e.RowIndex].Values[0]);
                var BookingID = Int32.Parse((string)e.CommandArgument);

                //  NewData.BookingId = Convert.ToInt32(gvBooking.SelectedRow.Cells[1].Text);
                //  NewData.User = gvBooking.SelectedRow.Cells[3].Text;
                // NewData.startDate, = Convert.ToDateTime(gvBooking.SelectedRow.Cells[4].Text);
                //   NewData.DateReservedTo = Convert.ToDateTime(gvBooking.SelectedRow.Cells[5].Text);

                var User1 = new Dmbl.User();
                User1 = (Dmbl.User)Session["User"];

                ctx.sp_UpdateBooking(
                     NewData.BookingId,
                     User1.UserId,
                     NewData.startDate,
                     NewData.endDate,
                     DateTime.Now);

                   



                ctx.SubmitChanges();
                PopulateBooking();
                txtNote.Visible = true;
               // string Booking = NewData.BookingID.ToString();
               // txtNote.InnerHtml = "Booking  " + Booking + " has been changed";

               // long r = NewData.BookingID;
     

            }
            if (e.CommandName == "Cancel")
            {
                return;
            }
        }
        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Booking NewData = new Booking();
            txtBookingID.Text = (gvBooking.SelectedRow.Cells[1].Text).ToString();


            //NewData.DateReservedFrom = Convert.ToDateTime(gvBooking.SelectedRow.Cells[4].Text);
            //NewData.DateReservedFrom = Convert.ToDateTime(gvBooking.SelectedRow.Cells[4].Text);
            //NewData.DateReservedTo = Convert.ToDateTime(gvBooking.SelectedRow.Cells[5].Text);
        }
    }

}