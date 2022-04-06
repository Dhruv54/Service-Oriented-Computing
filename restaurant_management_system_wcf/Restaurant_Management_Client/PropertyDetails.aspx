<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="PropertyDetails.aspx.cs" Inherits="Restaurant_Management_Client.PropertyDetails" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Property Details</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="container itemDetail">
        <div class="row">
            <div class="col-md-6">
                <asp:Image ID="itemImg" runat="server" ImageUrl="~/static/images/04.png"/>
            </div>
            <div class="col-md-6"  style="padding-top:5rem;">
                <label>Name:</label>
                <asp:Label ID="NameField" runat="server"></asp:Label>
                <br /><br />
                <label><i class="fa-solid fa-indian-rupee-sign"></i></label>
                <asp:Label ID="PriceField" runat="server"></asp:Label>&nbsp<label>Lac</label>
                <br /><br />
                <label><i class="fa-solid fa-location-dot"></i></label>
                <asp:Label ID="LocationField" runat="server"></asp:Label>
                <br /><br />
                <label>Category</label>
                <asp:Label ID="TypeField" runat="server"></asp:Label>
                <br /><br />
                <label>Agent:</label>
                <asp:Label ID="OwnerField" runat="server"></asp:Label>
                <br />
                 <div class="my-3">
                    <button class="btn btn-outline-info">Contact Agent</button>
                    <button class="btn btn-info">View Phone Number</button>
                </div>
            </div>
        </div>
        
    </div>
</asp:Content>
