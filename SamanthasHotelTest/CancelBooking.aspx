<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="SamanthasHotelTest.CancelBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:GridView ID="gvBookings" runat="server" AutoGenerateColumns="false" DataKeyNames="BookingID"
        PageSize="10" HeaderStyle-BackColor="LightSteelBlue" HeaderStyle-Font-Bold="true" AllowPaging="true" OnPageIndexChanging="gvBookings_PageIndexChanging" DeleteMethod="" OnRowCommand="gvBookings_RowCommand" OnRowDeleting="gvBookings_RowDeleting"  OnRowDeleted="gvBookings_RowDeleted">

        <Columns>
            <asp:BoundField DataField="BookingID" ShowHeader="true" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="DateReservedTo" HeaderText="Date Reserved To" />
             <asp:BoundField DataField="DateReservedFrom" HeaderText="Date Reserved From" />
            <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" ButtonType="Button"/>
        </Columns>
    </asp:GridView>

</asp:Content>
