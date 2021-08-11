using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayers;
using BusinessLogicLayer;
using DataAccessLayer;

public partial class _Default : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD = "deniz";
        ent.SOYAD = "çakmak";
        ent.NUMARA = "1234";
        ent.SIFRE = "1";
        ent.FOTOGRAF = "testyolu";
        bllOgrenci.OgrenciEkleBLL(ent);
    }
}