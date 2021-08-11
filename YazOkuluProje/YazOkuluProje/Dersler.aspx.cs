using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace YazOkuluProje
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> EntDers = BllDersler.BllListele();
                DropDownList1.DataSource = BllDersler.BllListele();
                DropDownList1.DataTextField = "dersAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }
            }

            protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASOGRID = int.Parse(TextBox1.Text);
            ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            BllDersler.TalepEkleBll(ent);
        }
    }
}