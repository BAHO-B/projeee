<%@ Page Title="" Language="C#" MasterPageFile="~/YetkiliPanel.Master" AutoEventWireup="true" CodeBehind="KitapEkle.aspx.cs" Inherits="AspnetKütüphaneProjesi.KitapEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/ekleguncelle.css" rel="stylesheet" />
    <div>
        <form runat="server">
            <h2>Kitap Ekleme Sayfası</h2>
            <div>
                <label for="KİTAPADI">Kitap Adı</label>
                <asp:TextBox BorderColor="gray" Width="100%" runat="server" ID="KİTAPADI" required="" />
            </div>
            <div>
                <label for="KATEGORİ">Kategori</label>
                <asp:TextBox BorderColor="gray" Width="100%" runat="server" ID="KATEGORİ" required="" />
            </div>
            <div>
                <label for="YAZAR">Yazar</label>
                <asp:TextBox BorderColor="gray" Width="100%" runat="server" ID="YAZAR" required="" />
            </div>
            <div>
                <label for="SAYFASAYISI">Sayfa Sayısı</label>
                <asp:TextBox BorderColor="gray" Width="100%" runat="server" ID="SAYFASAYISI" required="" />
            </div>
            <asp:Button Text="KİTAP KAYDET" CssClass="button" ID="KAYDET" runat="server" OnClick="KAYDET_Click" />
        </form>
    </div>
</asp:Content>
