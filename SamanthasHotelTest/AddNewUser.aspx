<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewUser.aspx.cs" Inherits="SamanthasHotelTest.AddNewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


   <div class="container">

  <div class="row">

    <div class="col-2">

    </div>
    <div class="col-8">
      
    <h4> Add a new user here</h4>
   
        <div>
            <p id="PageNoteAddUser" runat="server" hidden="hidden">.</p>
        </div>

        <label for="txtName">Name</label>
        <asp:TextBox id="txtName"   ToolTip="Name" runat="server" > required="true"</asp:TextBox>

       <label for="txtSurname">Surname</label>
        <asp:TextBox  id="txtSurname"  ToolTip="Surname"  runat="server">  required="true"</asp:TextBox>

        <label for="txtEmail">Email</label>
        <asp:TextBox id="txtEmail"  runat="server"  ToolTip="Email">  </asp:TextBox>
        <%--Check For Regex?--%>

      <label for="txtCellNumber">Cellnumber</label>
        <asp:TextBox id="txtCellNumber" maxlengh="10" ToolTip="CellNumber" runat="server" Text="Cellnumber">  </asp:TextBox>

        <label for="txtIdNumber">IDNumber</label>
                <asp:TextBox id="txtIdNumber" maxlengh="10" runat="server"> required="true" </asp:TextBox>

        <label for="inpAttachFile" ToolTip="Photo"> Attach a photo </label>
        <input id="inpAttachFile"   type="file" runat="server"/>

        <br />
        <br />
        <br />
        <asp:Button runat="server" ID="BtnSubmitBooking" OnClick="BtnSubmitBooking_Click"/>

    </div>

    <div class="col-2">

    </div>
  </div>
</div>
    

</asp:Content>
