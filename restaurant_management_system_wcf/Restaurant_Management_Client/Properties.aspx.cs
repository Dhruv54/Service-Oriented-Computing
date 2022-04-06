using Restaurant_Management;
using Restaurant_Management_Client.PropertyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class Properties : System.Web.UI.Page
    {
        string category = "All";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                try
                {
                    PropertyServiceClient client1 = new PropertyServiceClient();
                    client1.Open();
                    List<Property> prprties = client1.GetProperties().ToList().Take<Property>(15).ToList();
                    propertyRepeater.DataSource = prprties;
                    propertyRepeater.DataBind();
                    client1.Close();
                }
                catch (Exception)
                {

                }
            }

        }
        //public string GetImage(object imgName)
        //{
        //    PropertyServiceClient client = new PropertyServiceClient();
        //    client.Open();
        //    byte[] img = client.getPropertyPhoto(imgName.ToString());
        //    client.Close();
        //    if (img != null)
        //        return "data:image;base64," + Convert.ToBase64String(img);
        //    else
        //        return null;
        //}

        protected void all_Command(object sender, CommandEventArgs e)
        {
            PropertyServiceClient client = new PropertyServiceClient();
            client.Open();
            string arg = e.CommandArgument.ToString();

            if (arg.Equals("All", StringComparison.InvariantCultureIgnoreCase))
            {
                List<Property> prprties = client.GetProperties().ToList().Take<Property>(15).ToList();

                propertyRepeater.DataSource = prprties;
                propertyRepeater.DataBind();
            }
            else
            {
                category = arg;
                List<Property> items = client.getPropertyBycategory(arg).ToList().Take<Property>(15).ToList();

                propertyRepeater.DataSource = items;
                propertyRepeater.DataBind();
            }
            client.Close();
        }
    }
}