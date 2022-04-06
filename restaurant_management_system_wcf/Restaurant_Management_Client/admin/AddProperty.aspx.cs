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
    public partial class AddProperty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Property prprty = new Property
                {
                    Name = TextBox2.Text,
                    Price = Convert.ToInt32(TextBox3.Text),
                    Type = TextBox5.Text,
                    Location = TextBox4.Text,
                    Owner=TextBox6.Text
                };
                PropertyServiceClient client = new PropertyServiceClient();
                client.Open();
                try
                {
                    int id = client.AddProperty(prprty);
                    //client.UploadImage(id, FileUpload1.FileBytes);
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
}