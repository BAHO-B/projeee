using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessLayer;

namespace AspnetKütüphaneProjesi
{
    public partial class GirişSayfası : System.Web.UI.Page
    {

        DataModel dataModel = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void girişyap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullanıcıadı.Text;
            string sifre = şifre.Text;

            if (yetki.Text == "Yetkili" && kullaniciAdi != "" && sifre != "")
            {
                if (dataModel.YetkiliGiris(kullaniciAdi, sifre))
                {
                    Session["yetki"] = "yetkili";
                    Response.Redirect("/Kitap/KitapListesi.aspx");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Bilgilerinizi kontrol ediniz.')</script>");
                }
            }
            else if (yetki.Text == "Öğrenci" && kullaniciAdi != "" && sifre != "")
            {
                if (dataModel.OgrenciGiris(kullaniciAdi, sifre))
                {
                    Session["ogrenciAdSoyad"] = kullaniciAdi;
                    Response.Redirect("/Üye/ÜyePanel.aspx");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Bilgilerinizi kontrol ediniz.')</script>");
                }
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Lütfen yetki, kullanıcı adı ve şifre bilgilerini kontrol ediniz.')</script>");
            }
        }

        protected void kullanıcıadı_TextChanged(object sender, EventArgs e)
        {
        }

        protected void şifre_TextChanged(object sender, EventArgs e)
        {
        }

        protected void yetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}