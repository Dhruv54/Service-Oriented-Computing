<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="login.aspx.cs" Inherits="Restaurant_Management_Client.login" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Log In</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
<div>
    <div style="text-align:center;padding-top:15px;">
        <h2 class="login100-form-title">Log In</h2>
    </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <div class="card-body">
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox CssClass="form-control" ID="EmailField" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailField" ErrorMessage="Enter valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailField" ErrorMessage="Email id required"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>Password</label>
                    <asp:TextBox CssClass="form-control" ID="PasswordField" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ControlToValidate="PasswordField" ErrorMessage="Password required"></asp:RequiredFieldValidator>
                </div><br />
                <div class="container-login100-form-btn">
                    <asp:Button ID="Button1" runat="server" CssClass="login100-form-btn" OnClick="Button1_Click" Text="Sign In" />
                </div><br />
                &nbsp<asp:HyperLink NavigateUrl="/register.aspx" runat="server" CssClass="txt1">Create an Account?</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>