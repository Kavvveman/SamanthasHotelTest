<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookRoom.aspx.cs" Inherits="SamanthasHotelTest.BookRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <div class="row">
             
            <h4>Create a new booking!</h4>
                <p id="PageNote" hidden="hidden" runat="server" ></p>

            <br />

            <h6>Check In Date</h6>
            <input id='dtpDateBookedFrom' type="date" runat="server" required/>
            <br />

             <h6>Check Out Date</h6>
            <input id='dtpDateBookedTo' type="date" runat="server" required/>


            <h6 style="display: inline">Type of room Wanted</h6>
            <asp:DropDownList ID="cmbRoomType" runat="server" >

                <asp:ListItem id="Inside">Inside</asp:ListItem>

                <asp:ListItem id="Outside">Outside</asp:ListItem>

                <asp:ListItem id="Tent">Tent</asp:ListItem>

            </asp:DropDownList>
               <br /> 

            <asp:Button id="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Create booking"/>
        </div>

            </div>
           

          

</asp:Content>
