<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="SamanthasHotelTest.RescheduleBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <asp:DataGrid id="ItemsGrid"
           BorderColor="black"
           BorderWidth="1"
           CellPadding="3"
           AutoGenerateColumns="true"
           runat="server">

         <HeaderStyle BackColor="#00aaaa">
         </HeaderStyle> 
 
      </asp:DataGrid>

<%--    <asp:DataGrid id="dgMadeBookings" runat="server">
        <Columns></Columns>--%>


    </asp:DataGrid>

</asp:Content>
