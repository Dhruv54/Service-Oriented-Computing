<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/masters/main.Master" CodeBehind="Properties.aspx.cs" Inherits="Restaurant_Management_Client.Properties" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Properties</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <section class="food_section layout_padding-bottom">
    <div class="container">
        <img src="static/images/bg02.jpg" style="background-repeat:no-repeat;background-size: cover;position: fixed;top: 80px; width: 100vw; height: 574px;left:0%;">
        
      <%--<div style="position:absolute;">
        <h2>
          Properties
        </h2>
      </div>--%>
      <div class="filters-content">
          
        <div class="row grid">
            <asp:Repeater ID="propertyRepeater" runat="server">
            <ItemTemplate>
          <div class="col-sm-6 col-lg-4">
            <div class="box">

                <div class="img-box">
                  <asp:Image id="itemImg" ImageUrl="~/static/images/04.png" runat="server" />
                </div>
                <div class="detail-box">
                  <h4>
                    <asp:Label Text='<%#Eval("Name") %>' runat="server"></asp:Label>
                  </h4>
                   <h5>
                    <asp:Label Text='<%#Eval("Type") %>' runat="server"></asp:Label>
                  </h5>
                   <h6>
                    <label>Agent :</label>
                    <asp:Label Text='<%#Eval("Owner") %>' runat="server"></asp:Label>
                  </h6>
                  <p>
                    <i class="fa-solid fa-location-dot"></i>&nbsp&nbsp&nbsp&nbsp<asp:Label Text='<%#Eval("Location") %>' runat="server"></asp:Label>
                  </p>
                  <div>
                    <h4>
                     <i class="fa-solid fa-indian-rupee-sign"></i> <asp:Label Text='<%#Eval("Price") %>' runat="server"></asp:Label> Lac
                    <a href='/propertyDetails.aspx?id=<%#Eval("Id") %>'><i class="fa-solid fa-circle-info"></i></a>
                    </h4>
                  </div>
                </div>
            </div>
          </div>
                </ItemTemplate>
          </asp:Repeater>
        </div>    
      </div>
    </div>
  </section> 
</asp:Content>
