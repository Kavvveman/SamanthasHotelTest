<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditModal.aspx.cs" Inherits="SamanthasHotelTest.EditModal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

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
        <button type="button" id="btnSaveChanges" onclick="btnSaveChanges_Click" class="btn btn-primary">Save changes</button>
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>



</asp:Content>
