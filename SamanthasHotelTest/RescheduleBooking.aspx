<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="SamanthasHotelTest.RescheduleBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p id="txtNote" runat="server" hidden="hidden"> </p>

    <asp:GridView ID="gvBookings" runat="server" AutoGenerateColumns="false" DataKeyNames="BookingID"
        PageSize="10" OnRowUpdating="gvBookings_RowUpdating" OnRowEditing="gvBookings_RowEditing" AllowPaging="true" OnRowCancelingEdit="gvBookings_RowCancelingEdit" OnRowUpdated="gvBookings_RowUpdated" OnPageIndexChanging="gvBookings_PageIndexChanging">

        <Columns>
            <asp:BoundField DataField="BookingID" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="DateReservedTo" HeaderText="Date Reserved To" />
             <asp:BoundField DataField="DateReservedFrom" HeaderText="Date Reserved From" />
            <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField ButtonType="Button" EditText="Edit" UpdateText="Update" ShowEditButton="true" />
       
        </Columns>
    </asp:GridView>

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


