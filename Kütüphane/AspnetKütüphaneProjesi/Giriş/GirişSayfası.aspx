<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirişSayfası.aspx.cs" Inherits="AspnetKütüphaneProjesi.GirişSayfası" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Giriş Yap</title>
    <meta charset="UTF-8">
    <link href="../css/style.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
        <div class="kapsayici">
            <div class="giris-kutusu">
                <div class="giris-baslik">Giriş Yap</div>
                <div class="giris-alani">
                    <label for="kullanıcıadı">Kullanıcı Adı</label>
                    <br>
                    <asp:TextBox ID="kullanıcıadı" runat="server" required=""/>
                    <br>
                    <label for="sifre">Şifre</label>
                    <br>
                    <asp:TextBox TextMode="Password" ID="şifre" runat="server" required=""/>
                    <br>
                    <label for="yetki">Yetki</label>
                    <br>
                    <asp:DropDownList ID="yetki"  runat="server">
                        <asp:ListItem Text="Yetkili" />
                        <asp:ListItem Text="Öğrenci" />
                    </asp:DropDownList>
                    <br>
                     <asp:Button Style="font-family: Calibri;" Text="Giriş Yap" CssClass="giris-butonu" ID="girişyap" runat="server" OnClick="girişyap_Click" />
                    <br>
                    <a class="uye-ol" href="../Üye/ÜyeKayıt.aspx">Üye Ol</a>
                    <br>
                    <span class="uyari"></span>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
