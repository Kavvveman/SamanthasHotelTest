<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="SamanthasHotelTest.CancelBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--  <asp:DataGrid id="dgBookings" runat="server" AutoGenerateColumns="false" PageSize="15" AllowPaging="true" OnPageIndexChanged="dgBookings_PageIndexChanged">
        <HeaderStyle CssClass="Grid" Width="70%"  Height="70%" BorderStyle="Solid"/>
        <Columns>
            <asp:BoundColumn DataField="BookingID" HeaderText="Booking ID"></asp:BoundColumn>
            <asp:BoundColumn DataField="UserID" HeaderText="UserID"></asp:BoundColumn>
            <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>
            <asp:BoundColumn DataField="DateCreated" HeaderText="Date Created"></asp:BoundColumn>
            <asp:BoundColumn DataField="IsActiveBooking" HeaderText="Is Active Booking"></asp:BoundColumn>
            <asp:ButtonColumn ButtonType="LinkButton"  CommandName="DeleteBooking"> </asp:ButtonColumn>
          
        </Columns>
    </asp:DataGrid>--%>

    <asp:GridView ID="gvBookings" runat="server" AutoGenerateColumns="false" DataKeyNames="BookingID"
        PageSize="10" AllowPaging="true" OnPageIndexChanging="gvBookings_PageIndexChanging" DeleteMethod="" OnRowCommand="gvBookings_RowCommand" OnRowDeleting="gvBookings_RowDeleting"  OnRowDeleted="gvBookings_RowDeleted">

        <Columns>
            <asp:BoundField DataField="BookingID" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="DateReservedTo" HeaderText="Date Reserved To" />
             <asp:BoundField DataField="DateReservedFrom" HeaderText="Date Reserved From" />
            <%--Dates to be reserved--%>
            <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete" ButtonType="Button"/>
       
       
        </Columns>
    </asp:GridView>

   




</asp:Content>
