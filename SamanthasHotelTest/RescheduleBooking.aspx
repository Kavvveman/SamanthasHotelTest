<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="SamanthasHotelTest.RescheduleBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:DataGrid ID="dgBookings" runat="server" AutoGenerateColumns="false" PageSize="20" AllowPaging="true" OnPageIndexChanged="dgBookings_PageIndexChanged" OnEditCommand="dgBookings_EditCommand" DataKeyNames="BookingID"  >
       <Columns>
           <asp:BoundColumn DataField="BookingID"></asp:BoundColumn>
           <asp:BoundColumn DataField="UserID"></asp:BoundColumn>
           <asp:BoundColumn DataField="Name"></asp:BoundColumn>
           <%--Reserved Dates--%>
           <asp:EditCommandColumn EditText="'" ></asp:EditCommandColumn>
           <asp:EditCommandColumn></asp:EditCommandColumn>
       </Columns>
    </asp:DataGrid>

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


