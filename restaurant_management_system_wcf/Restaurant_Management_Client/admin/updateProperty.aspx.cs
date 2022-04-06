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
    public partial class updateProperty : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                PropertyServiceClient client = new PropertyServiceClient();
                client.Open();
                try
                {
                    Property prprty = client.GetProperty(id);
                    Label2.Text = id.ToString();
                    TextBox2.Text = prprty.Name;
                    TextBox3.Text = prprty.Price.ToString();
                    TextBox4.Text = prprty.Location;
                    TextBox5.Text = prprty.Type;
                    TextBox6.Text = prprty.Owner;
             
                }
                catch (Exception)
                {
                    Response.Redirect("/admin/dashboard.aspx");
                }
                finally
                {
                    client.Close();
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PropertyServiceClient client = new PropertyServiceClient();
            client.Open();
            try
            {
                Property prprty = new Property
                {
                    Id = id,
                    Name = TextBox2.Text,
                    Price = Convert.ToInt32(TextBox3.Text),
                    Location = TextBox4.Text,
                    Type = TextBox5.Text,
                    Owner=TextBox6.Text
                };
                client.UpdateProperty(prprty);
                //if (FileUpload1.HasFile)
                //{
                //    client.UploadImage(id, FileUpload1.FileBytes);
                //}
                Response.Redirect("/admin/Properties.aspx");
            }
            catch (Exception ex)
            {
                errPanel.Visible = true;

                Label1.Text = ex.Message;
            }
            finally
            {
                client.Close();
            }
        }
    }
}