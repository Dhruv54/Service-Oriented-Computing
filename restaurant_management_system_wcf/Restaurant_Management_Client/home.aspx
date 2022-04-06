<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" MasterPageFile="~/masters/main.Master" CodeBehind="home.aspx.cs" Inherits="Restaurant_Management_Client.home" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Home</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
      <%--<div class="filters-content">
        <div class="row grid">
            <asp:Repeater ID="itemRepeater" runat="server">
         <ItemTemplate>
          <div class="col-sm-6 col-lg-4">
            <div class="box">
                <div class="img-box">
                  <asp:Image id="itemImg" ImageUrl="~/static/images/burger_slide.png" runat="server" />
                </div>
                <div class="detail-box">
                  <h5>
                    <asp:Label Text='<%#Eval("Name") %>' runat="server"></asp:Label>
                  </h5>
                  <p>
                    <asp:Label Text='<%#Eval("Description") %>' runat="server"></asp:Label>
                  </p>
                  <div class="options">
                    <h6>
                       ₹<asp:Label Text='<%#Eval("Price") %>' runat="server"></asp:Label>
                    </h6>
                    <a href='/itemDetails.aspx?id=<%#Eval("Id") %>' ><i class='fa-solid fa-cart-shopping'></i></a>
                  </div>
                </div>
            </div>
          </div>
        </ItemTemplate>
          </asp:Repeater>
        </div>  
      </div>--%>
    <div>
        <div>
            <img src="static/images/bg02.jpg" style="background-repeat:no-repeat;background-size: cover;position: absolute;top: 80px; width: 100vw; height: 574px;">
        </div>
        <div style="position:absolute;top:95px;left:30%;text-align:center;color:aliceblue;">
            <h1>To Each Their Home</h1>
            <h2>Let's Find a Home that's perfect for you.   :D</h2>
        </div>
        <div style="position:absolute;top:500px;left:26%;text-align:center;width:70rem;">
            <div class="row">
                <div class="col-md-8">
                    <div class="input-group mb-3"> <input type="text" style="background-color:mintcream;" class="form-control input-text" placeholder="Search products...." aria-label="Recipient's username" aria-describedby="basic-addon2">
                        <div class="input-group-append"> <button class="btn btn-outline-warning btn-lg" type="button"><i class="fa fa-search"></i></button> </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="bottom:100px;position:absolute;display:flex;left:500px;text-align:center;">
            <div class="mx-4">
                <label style="color:aqua">1000</label>
                <p style="color:mintcream">Home for sale</p>
            </div>
            <div class="mx-4">
                <label style="color:aqua">1400</label>
                <p style="color:mintcream">Farm House for sale</p>
            </div>
            <div class="mx-4">
                <label style="color:aqua">4569</label>
                <p style="color:mintcream">Properties</p>
            </div>
        </div>
    </div>
</asp:Content>
