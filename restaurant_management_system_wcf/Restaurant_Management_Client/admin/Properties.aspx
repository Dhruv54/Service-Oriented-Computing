<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/admin.Master" CodeBehind="Properties.aspx.cs" Inherits="Restaurant_Management_Client.admin.Properties" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Properties</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="container my-3" id="dashboard">

        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
        <label>Number Of Properties:</label><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/AddProperty.aspx"><i class="fa-solid fa-plus" style="font-size:20px;"></i> Add Property </asp:HyperLink>
        <br />
        <br />
        <table class="table my-3">
            <thead>
                <tr>
                    <th scope="col">Id</th>
                    <th scope="col">Property</th>
                    <th scope="col">Price</th>
                    <th scope="col">Type</th>
                    <th scope="col">Location</th>
                    <th scope="col">Agent</th>
                    <th scope="col">Image</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="itemtable" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("Id") %></th>
                            <td><%#Eval("Name") %></td>
                            <td><%#Eval("Price") %>&nbsp Lac</td>
                            <td><%#Eval("Type") %></td>
                            <td><%#Eval("Location") %></td>
                            <td><%#Eval("Owner") %></td>
                            <td>
                                <asp:Image ID="itemImg" Width="40px" Height="40px" ImageUrl="~/static/images/realestate.png" runat="server" /></td>
                            <td>
                                <asp:Button runat="server" OnCommand="update_Command" CommandArgument='<%#Eval("Id") %>' Text="Update" CssClass="btn btn-primary" />
                                <asp:Button runat="server" OnCommand="delete_Command" CommandArgument='<%#Eval("Id") %>' Text=" Delete" CssClass="btn btn-danger" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>