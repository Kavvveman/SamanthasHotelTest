<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="SamanthasHotelTest.RescheduleBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <a href="Content/bootstrap.min.css.map">Content/bootstrap.min.css.map</a>
    <a href="Content/bootstrap-theme.min.css.map">Content/bootstrap-theme.min.css.map</a>
    <style></style>

    <h6 id="txtNote" runat="server" hidden="hidden"></h6>

    <asp:GridView ID="gvBooking"
        runat="server"
        AutoGenerateColumns="false"
        DataKeyNames="BookingID"
        PageSize="10"
        EmptyDataText="false"
        OnRowUpdating="gvBooking_RowUpdating"
        OnRowCommand="gvBooking_RowCommand"
        OnRowEditing="gvBooking_RowEditing"
        HeaderStyle-BorderColor="SteelBlue"
        AllowPaging="true"
        OnRowCancelingEdit="gvBooking_RowCancelingEdit"
        OnRowUpdated="gvBooking_RowUpdated"
        OnPageIndexChanging="gvBooking_PageIndexChanging">

        <Columns>

            <asp:BoundField DataField="BookingId" ShowHeader="true" HeaderText="Booking Id" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" />
            <asp:BoundField DataField="startDate" HeaderText="Date Reserved To" />
            <asp:BoundField DataField="endDate" HeaderText="Date Reserved From" />
            <asp:BoundField DataField="costOfBooking" HeaderText="Booking Cost" />
            <asp:BoundField DataField="CreatedOn" HeaderText="DateCreated" />
            <asp:BoundField DataField="IsActiveBooking" HeaderText="IsActiveBooking" />
            <asp:CommandField  ShowEditButton="true" ButtonType="Button" EditText="Edit" UpdateText="Update" ShowSelectButton="true" />
<%--            <asp:TemplateField HeaderText="Edit">
                <EditItemTemplate>
                    <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update" />
                    <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" />
                </EditItemTemplate>
            </asp:TemplateField>--%>
        </Columns>

    </asp:GridView>

    <button type="button" class="btn btn-primary" data-toggle="modal">
    </button>

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
                    <asp:Label runat="server">Date Booked From</asp:Label>
                    <asp:TextBox ID="txtDateBookedFrom" runat="server" BorderStyle="None"></asp:TextBox>
                    <asp:Label runat="server"> Date Booked To</asp:Label>
                    <asp:TextBox ID="txtDateBookedTo" runat="server" BorderStyle="None"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary">Save changes</button>
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>


</asp:Content>

<%--    <asp:DataGrid id="dgMadeBooking" runat="server">
        <Columns></Columns>--%>


