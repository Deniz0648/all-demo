using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluProje
{
    public partial class ÖğrenciGüncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(Request.QueryString["ogrID"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
            List<EntityOgrenci> Ogrlist = bllOgrenci.BllDetay(x);
            TxtAd.Text = Ogrlist[0].AD.ToString();
            TxtSoyad.Text = Ogrlist[0].SOYAD.ToString();
            TxtNumara.Text = Ogrlist[0].NUMARA.ToString();
            TxtFoto.Text = Ogrlist[0].FOTOGRAF.ToString();
            TxtSifre.Text = Ogrlist[0].SIFRE.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            ent.ID =Convert.ToInt32( TxtId.Text);
            bllOgrenci.OgrenciGulcelle(ent);
            Response.Redirect("ÖğrenciListesi.aspx");
        }
    }
}