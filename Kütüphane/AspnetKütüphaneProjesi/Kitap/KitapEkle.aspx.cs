using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetKütüphaneProjesi
{
    public partial class KitapEkle : System.Web.UI.Page
    {
        DataModel dataModel = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void KAYDET_Click(object sender, EventArgs e)
        {
            DataModel dataModel = new DataModel();
            if (dataModel.KitapEkle(KİTAPADI.Text, KATEGORİ.Text, YAZAR.Text, SAYFASAYISI.Text))
            {
                Response.Redirect("KitapListesi.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Kayıt işlemi başarısız.')</script>");
            }
        }
    }
}