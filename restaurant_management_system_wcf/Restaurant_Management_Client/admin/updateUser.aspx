<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateUser.aspx.cs" MasterPageFile="~/masters/admin.Master" Inherits="Restaurant_Management_Client.admin.updateUser" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Update User</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div style="text-align:center;padding-top:15px;">
        <h2 class="login100-form-title">Update User</h2>
    </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
        <div class="card-body">

            <div>
                <div class="form-group">
                    <label></label>
                    <asp:Label ID="Label4" runat="server" Visible="false"></asp:Label>
                </div>
                <div class="form-group">
                    <lanel>Name</lanel>
                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name required"></asp:RequiredFieldValidator>

                </div><br />
                <div class="form-group">
                    <label>Email:</label>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <br /><label>Contact: 1234567899</label>
                </div>
                <div class="form-group">

                    <label>Role</label>
                    <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Role required"></asp:RequiredFieldValidator>
                    <br />
                </div>
                <div class="container-login100-form-btn">
                    <asp:Button ID="Button1" CssClass="login100-form-btn" runat="server" OnClick="Button1_Click" Text="update" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
