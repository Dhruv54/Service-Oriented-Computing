using Restaurant_Management;
using Restaurant_Management_Client.PropertyServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.admin
{
    public partial class Properties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                updatePropertyTable();
            }
        }

        void updatePropertyTable()
        {
            PropertyServiceClient client = new PropertyServiceClient();
            client.Open();
            try
            {
                List<Property> prprty = client.GetProperties().ToList();
                Label1.Text = prprty.Count.ToString();
                itemtable.DataSource = prprty;
                itemtable.DataBind();
            }
            catch (Exception ex)
            {
                errPanel.Visible = true;
                Label2.Text = ex.Message;
            }
            finally
            {
                client.Close();
            }
        }
        protected void update_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("/admin/updateProperty.aspx?id=" + e.CommandArgument.ToString());
        }

        protected void delete_Command(object sender, CommandEventArgs e)
        {
            PropertyServiceClient client = new PropertyServiceClient();
            client.Open();
            client.DeleteProperty(Convert.ToInt32(e.CommandArgument));
            client.Close();
            updatePropertyTable();
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
    }
}