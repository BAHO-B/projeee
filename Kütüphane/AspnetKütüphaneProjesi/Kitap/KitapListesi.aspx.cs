using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AspnetKütüphaneProjesi
{
    public partial class KitapListesi : System.Web.UI.Page
    {
        DataModel dataModel = new DataModel();
        string id = ""; string islem = "";
        private void kitaplistele()
        {
            SqlDataReader reader;
            dataModel.KitapListele(out reader);
            kitap.DataSource = reader;
            kitap.DataBind();
            reader.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            islem = Request.QueryString["islem"];

            kitaplistele();
            if (islem == "sil")
            {
                int bul = Convert.ToInt32(id);
                dataModel.KitapSil(bul);
                Response.Redirect("KitapListesi.aspx");
            }
        }
    }
}