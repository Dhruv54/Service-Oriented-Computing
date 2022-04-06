using Restaurant_Management;
using Restaurant_Management.Dto;
using Restaurant_Management_Client.AccountServiceReference;
using Restaurant_Management_Client.ItemServiceReference;
using Restaurant_Management_Client.OrderServiceReference;
using Restaurant_Management_Client.PropertyServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{

            //    try
            //    {
            //        PropertyServiceClient client1 = new PropertyServiceClient();
            //        client1.Open();
            //        List<Property> prprs = client1.GetProperties().ToList().Take<Property>(9).ToList();
            //        itemRepeater.DataSource = prprs;
            //        itemRepeater.DataBind();
            //        client1.Close();
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}

        }

        //public string GetImage(object imgName)
        //{
        //    ItemServiceClient client = new ItemServiceClient();
        //    client.Open();
        //    //byte[] img = client.getItemPhoto(imgName.ToString());
        //    client.Close();
        //    //if (img != null)
        //    //    return "data:image;base64," + Convert.ToBase64String(img);
        //    //else
        //    //    return null;
        //}

        //protected void all_Command(object sender, CommandEventArgs e)
        //{
        //    PropertyServiceClient client = new PropertyServiceClient();
        //    client.Open();
        //    string arg = e.CommandArgument.ToString();
        //    if(arg.Equals("all", StringComparison.CurrentCultureIgnoreCase))
        //    {
        //        List<Property> prprs = client.GetProperties().ToList().Take<Property>(9).ToList();
        //        itemRepeater.DataSource = prprs;
        //        itemRepeater.DataBind();
        //    }
        //    else
        //    {
        //        List<Property> prprs = client.getPropertyBycategory(arg).ToList().Take<Property>(9).ToList();
        //        itemRepeater.DataSource = prprs;
        //        itemRepeater.DataBind();
        //    }
        //    client.Close();
        //}

    }
}