<%@ Page Title="" Language="C#" MasterPageFile="~/YetkiliPanel.Master" AutoEventWireup="true" CodeBehind="KitapGüncelle.aspx.cs" Inherits="AspnetKütüphaneProjesi.KitapGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/ekleguncelle.css" rel="stylesheet" />
    <form runat="server">
        <div>
            <h2>Kitap Düzenleme Sayfası</h2>
            <br />
            <label for="KİTAPADI">Kitap Adı</label>
            <asp:TextBox BorderColor="gray" Width="96%" runat="server" ID="KİTAPADI" required="" />
        </div>
        <br />
        <div>
            <label for="KATEGORİ">Kategori</label>
            <asp:TextBox BorderColor="gray" Width="96%" runat="server" ID="KATEGORİ" required="" />
        </div>
        <br />
        <div>
            <label for="YAZAR">Yazar</label>
            <asp:TextBox BorderColor="gray" Width="96%" runat="server" ID="YAZAR" required="" />
        </div>
        <br />
        <div>
            <label for="SAYFASAYISI">Sayfa Sayısı</label>
            <asp:TextBox BorderColor="gray" Width="96%" runat="server" ID="SAYFASAYISI" required="" />
        </div>
        <br />
        <asp:Button CssClass="button" Text="GÜNCELLE" ID="GÜNCELLE" runat="server" OnClick="GÜNCELLE_Click" />
    </form>
</asp:Content>
