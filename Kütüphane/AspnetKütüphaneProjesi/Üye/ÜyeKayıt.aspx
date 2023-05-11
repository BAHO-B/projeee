<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ÜyeKayıt.aspx.cs" Inherits="AspnetKütüphaneProjesi.ÜyeKayıt" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Kullanıcı Girişi</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../css/style.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <div class="kapsayici">
            <div class="giris-kutusu">
                <div class="giris-baslik">Üye Kayıt Ekranı</div>
                <div class="giris-alani">
                    <label>Ad Soyad</label>
                    <br>
                    <asp:TextBox ID="adsoyad" runat="server" required=""/>
                    <br>
                    <label>Kullanıcı Adı</label>
                    <br>
                    <asp:TextBox ID="kullanıcıadı" runat="server" required=""/>
                    <br>
                    <label>E-Mail</label>
                    <br>
                    <asp:TextBox ID="email" runat="server" required=""/>
                    <br>
                    <label>Şifre</label>
                    <br>
                    <asp:TextBox TextMode="Password" ID="şifre" runat="server" required=""/>
                    <br>
                    <asp:Button Style="font-family: Calibri;" Text="Kayıt Ol" CssClass="giris-butonu" ID="kayıtol" runat="server" OnClick="kayıtol_Click" />
                    <br>
                    <a class="uye-ol" href="../Giriş/GirişSayfası.aspx">Giriş Yap</a>
                    <br>
                    <span class="uyari"></span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
