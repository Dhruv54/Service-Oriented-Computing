using Restaurant_Management;
using Restaurant_Management.Dto;
using Restaurant_Management.models;
using Restaurant_Management_Client.AccountServiceReference;
using Restaurant_Management_Client.ItemServiceReference;
using Restaurant_Management_Client.OrderServiceReference;
using Restaurant_Management_Client.PropertyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class PropertyDetails : System.Web.UI.Page
    {
        Property prp;
        UserDto user;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string token = Request.Cookies["token"].Value;
            AccountServiceClient client1 = new AccountServiceClient();
            client1.Open();
            user = client1.GetUserByToken(token);
            if (id != null)
            {
                PropertyServiceClient client = new PropertyServiceClient();
                client.Open();
                try
                {
                    prp = client.GetProperty(Convert.ToInt32(id));
                    //byte[] img= client.getItemPhoto(item.ImagePath);
                    //itemImg.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                    NameField.Text = prp.Name;
                    PriceField.Text = prp.Price.ToString();
                    LocationField.Text = prp.Location;
                    TypeField.Text = prp.Type;
                    OwnerField.Text = prp.Owner;
                }
                catch (Exception)
                {
                    Response.Redirect("/home.aspx");
                }
                client.Close();
            }
            else
                Response.Redirect("/home.aspx");
            client1.Close();
        }
    }
}