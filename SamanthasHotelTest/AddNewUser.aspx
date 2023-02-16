<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewUser.aspx.cs" Inherits="SamanthasHotelTest.AddNewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <formview>


   <div class="container">

  <div class="row">

    <div class="col-2">

    </div>
    <div class="col-8">
      
    <h4 id="PageNoteAddUser" runat="server"> Add a new user here</h4>
   
<%--        <div>
            <p id="PageNoteAddUser" runat="server" hidden="hidden">.</p>
        </div>--%>



        <label for="txtName">Name</label>
        <asp:TextBox id="txtName"   ToolTip="Name" runat="server" required="true"> </asp:TextBox>

        <br />
        <br />


       <label for="txtSurname">Surname</label>
        <asp:TextBox  id="txtSurname"  ToolTip="Surname" required="true"  runat="server">  </asp:TextBox>


        <br />
        <br />


        <label for="txtEmail">Email</label>
        <asp:TextBox id="txtEmail"  runat="server"  ToolTip="Email">  </asp:TextBox>
        <%--Check For Regex?--%>

        <br />
        <br />

       <label for="txtCellNumber">Cellnumber</label>
        <asp:TextBox id="txtCellNumber" maxlengh="10" ToolTip="CellNumber" required="true" runat="server" Text="">  </asp:TextBox>

        <br />
        <br />

        <label for="txtIdNumber">IDNumber</label>
       <asp:TextBox id="txtIdNumber" maxlengh="10" runat="server"  required="true"> </asp:TextBox>

        <br />

        <label for="inpAttachFile" ToolTip="Photo"> Attach a photo </label> 
        <input style="display:inline" id="inpAttachFile"   type="file" runat="server"/>

       
        <br />
            <br />
            <br />

            <asp:button ID="BtnCreateUser" runat="server" OnClick="BtnCreateUser_Click" text="Create User"/>

            

    </div>

    <div class="col-2">

    </div>
  </div>
</div>
   </formview>

</asp:Content>
