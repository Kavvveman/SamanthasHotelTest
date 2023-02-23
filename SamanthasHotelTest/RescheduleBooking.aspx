<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="SamanthasHotelTest.RescheduleBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <a href="Content/bootstrap.min.css.map">Content/bootstrap.min.css.map</a>
    <a href="Content/bootstrap-theme.min.css.map">Content/bootstrap-theme.min.css.map</a>
    <style ></style>

    <p id="txtNote" runat="server" hidden="hidden"> </p>

    <asp:GridView ID="gvBookings" 
        runat="server" 
        AutoGenerateColumns="false"
        DataKeyNames="BookingID"
        PageSize="10"
        EmptyDataText="false" 
        OnRowUpdating="gvBookings_RowUpdating"
        OnRowCommand="gvBookings_RowCommand"
        OnRowEditing="gvBookings_RowEditing" 
        HeaderStyle-BorderColor="SteelBlue"
        AllowPaging="true"
        OnRowCancelingEdit="gvBookings_RowCancelingEdit" 
        OnRowUpdated="gvBookings_RowUpdated"
        OnPageIndexChanging="gvBookings_PageIndexChanging">

        <Columns>
            <asp:BoundField DataField="BookingID" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="DateReservedTo" HeaderText="Date Reserved To" />
             <asp:BoundField DataField="DateReservedFrom" HeaderText="Date Reserved From" />
            <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField ButtonType="Button"  UpdateText="Update" ShowSelectButton="true" />
       
<%--             <asp:BoundField HeaderText="Manager"
                    />--%>
<%--                    <asp:TemplateField HeaderText="Allocation Percentage">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"
                            Text= '<%# Bind("BookedFromDate") %>' BorderStyle="None"></asp:TextBox>
                    </ItemTemplate>
                    </asp:TemplateField>--%>

        </Columns>






    </asp:GridView>

<button type="button" class="btn btn-primary" data-toggle="modal" >

</button>
    
<div class="modal" runat="server" id="editModal" tabindex="-1" role="dialog">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Modal title</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <asp:Label runat="server"> Booking ID</asp:Label>
        <asp:TextBox ID="txtBookingID" runat="server" BorderStyle="None"></asp:TextBox>
               <asp:Label runat="server" >Date Booked From</asp:Label>
        <asp:Textbox ID="txtDateBookedFrom" runat="server" BorderStyle="None"></asp:Textbox>
               <asp:Label runat="server" > Date Booked To</asp:Label>
        <asp:Textbox ID="txtDateBookedTo" runat="server" BorderStyle="None"></asp:Textbox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary">Save changes</button>
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>


<%--    <asp:GridView ID="gvBookings" CssClass="Grid" runat="server" AutoGenerateColumns="false"
        PageSize="10" AllowPaging="true" OnPageIndexChanging="gvBookings_PageIndexChanging" DataKeyNames="BookingID"  OnRowDeleting="gvBookings_RowDeleting" OnRowDeleted="gvBookings_RowDeleted">
        
        <Columns >
            <asp
            <asp:BoundField DataField="BookingID"  HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField  runat="server" ButtonType="Button" ShowDeleteButton="true"  />
        </Columns>
    </asp:GridView>--%>
 

    </asp:Content >

<%--    <asp:DataGrid id="dgMadeBookings" runat="server">
        <Columns></Columns>--%>


