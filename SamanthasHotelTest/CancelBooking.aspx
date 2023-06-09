<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="SamanthasHotelTest.CancelBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:GridView ID="gvBooking" runat="server" AutoGenerateColumns="false" DataKeyNames="BookingId"
        PageSize="10" HeaderStyle-BackColor="LightSteelBlue" HeaderStyle-Font-Bold="true" AllowPaging="true" OnPageIndexChanging="gvBooking_PageIndexChanging" DeleteMethod="" OnRowCommand="gvBooking_RowCommand" OnRowDeleting="gvBooking_RowDeleting" OnRowDeleted="gvBooking_RowDeleted">

        <Columns>
            <asp:BoundField DataField="BookingId" ShowHeader="true" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="startDate" HeaderText="Date Reserved To" />
            <asp:BoundField DataField="endDate" HeaderText="Date Reserved From" />
            <asp:BoundField DataField="costOfBooking" HeaderText="Booking Cost" />
            <asp:BoundField DataField="CreatedOn" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" ButtonType="Button" />
        </Columns>
    </asp:GridView>

</asp:Content>
