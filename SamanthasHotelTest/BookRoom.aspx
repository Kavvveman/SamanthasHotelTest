<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookRoom.aspx.cs" Inherits="SamanthasHotelTest.BookRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h4>Create a new booking!</h4>
            <br />

            <h6>Check In Date</h6>
            <input id='dtpDateBookedFrom' type="date" runat="server" />
            <br />

             <h6>Check Out Date</h6>
            <input id='dtpDateBookedTo' type="date" runat="server" />


            <h6>Type of room Wanted</h6>
            <asp:DropDownList ID="cmbRoomType" runat="server">

                <asp:ListItem id="Inside">Inside</asp:ListItem>

                <asp:ListItem id="Outside">Outside</asp:ListItem>

                <asp:ListItem id="Tent">Tent</asp:ListItem>

            </asp:DropDownList>
            <asp:Button id="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Create booking"/>
        </div>

</asp:Content>
