using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetKütüphaneProjesi
{
    public partial class KitapGüncelle : System.Web.UI.Page
    {
        DataModel dataModel = new DataModel();
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                int kitapid = Convert.ToInt32(id);
                dataModel.KitapGetir(kitapid, out string kitapadi, out string kategori, out string yazar, out string sayfasayisi);
                KİTAPADI.Text = kitapadi;
                KATEGORİ.Text = kategori;
                YAZAR.Text = yazar;
                SAYFASAYISI.Text = sayfasayisi;
            }
        }

        protected void GÜNCELLE_Click(object sender, EventArgs e)
        {
            DataModel dataModel = new DataModel();
            bool result = dataModel.KitapGüncelle(Convert.ToInt32(id), KİTAPADI.Text, KATEGORİ.Text, YAZAR.Text, SAYFASAYISI.Text);
            if (result)
            {
                Response.Redirect("KitapListesi.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Güncelleme işlemi sırasında bir hata oluştu.')</script>");
            }
        }
    }
}