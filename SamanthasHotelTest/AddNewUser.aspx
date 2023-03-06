<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewUser.aspx.cs" Inherits="SamanthasHotelTest.AddNewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <formview>


        <div class="container">

            <div class="row">

                <div class="col-2">
                </div>
                <div class="col-8">

                    <h4 id="PageNoteAddUser" runat="server">Add a new user here</h4>

                    <%--        <div>
            <p id="PageNoteAddUser" runat="server" hidden="hidden">.</p>
        </div>--%>



                    <label for="txtName">Name</label>
                    <asp:TextBox ID="txtName" ToolTip="Name" runat="server" Text="Name" required="true"> </asp:TextBox>

                    <br />
                    <br />


                    <label for="txtSurname">Surname</label>
                    <asp:TextBox ID="txtSurname" ToolTip="Surname" required="true" Text="Surname" runat="server">  </asp:TextBox>


                    <br />
                    <br />


                    <label for="txtEmail">Email</label>
                    <asp:TextBox ID="txtEmail" TextMode="Email" runat="server" ToolTip="Email" Text="Email">   </asp:TextBox>
                    <%--Check For Regex?--%>

                    <br />
                    <br />

                    <label for="txtCellNumber">Cellnumber</label>
                    <asp:TextBox ID="txtCellNumber" maxlengh="10" TextMode="Number" ToolTip="CellNumber" required="true" runat="server" Text="Cellnum">  </asp:TextBox>

                    <br />
                    <br />

                    <label for="txtIdNumber">IDNumber</label>
                    <asp:TextBox ID="txtIdNumber" maxlengh="10" runat="server" TextMode="Number" required="true"> </asp:TextBox>

                    <label for="txtPassword">Password</label>
                    <asp:TextBox TextMode="Password" ID="txtPassword" runat="server" required="true" ></asp:TextBox>
                  

                    <%--<asp:RegularExpressionValidator id="RegularExpressionValidator1" runat="server" ErrorMessage="IDNumber Can only Contain Numbers" ValidationExpression="[0-9]*" ControlToValidate="txtIdNumber"></asp:RegularExpressionValidator>--%>


                    <br />

                    <label for="inpAttachFile" tooltip="Photo">Attach a photo </label>
                    <input style="display: inline" id="inpAttachFile" type="file" runat="server" />


                    <br />
                    <br />
                    <br />

                    <asp:Button ID="btnCreateUser" runat="server" onclick="btnCreateUser_Click" Text="Create User" />

                    <%--        <asp:button id="btnSubmit" runat="server" onclick="btnCreateUser_Click" Text="Create"> </asp:button>--%>
                </div>

                <div class="col-2">
                </div>
            </div>
        </div>
    </formview>

</asp:Content>
