<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookRoom.aspx.cs" Inherits="SamanthasHotelTest.BookRoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <div class="row">
             
            <h4>Create a new booking!</h4>

                <p id="PageNote" visible="false" runat="server" ></p>

            <br />

            <h6>Check In Date</h6>

            <asp:TextBox runat="server" TextMode="Date" ID="txtDateBookedFrom"> </asp:TextBox>
            <br />

             <h6>Check Out Date</h6>
       
                <asp:TextBox runat="server" TextMode="Date" ID="txtDateBookedTo"> </asp:TextBox>

               <br /> 
                <br />
            <asp:Button id="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Create booking"/>
        </div>

            </div>
    <br />
    <br />
           
               <p runat="server">The Cost of your booking is </p>  
                <p runat="server" id="txtBookingPrice" hidden="hidden"> </p>
          

</asp:Content>
