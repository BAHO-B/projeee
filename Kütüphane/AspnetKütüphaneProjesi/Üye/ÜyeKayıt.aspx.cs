using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetKütüphaneProjesi
{
    public partial class ÜyeKayıt : System.Web.UI.Page
    {
        DataModel dataModel = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kayıtol_Click(object sender, EventArgs e)
        {
            dataModel.OgrenciKayit(adsoyad.Text, kullanıcıadı.Text, email.Text, şifre.Text);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Kayıt başarılı. Giriş ekranına yönlendiriliyorsunuz..')</script>");
            Response.Redirect("/Giriş/GirişSayfası.aspx");
        }
    }
}