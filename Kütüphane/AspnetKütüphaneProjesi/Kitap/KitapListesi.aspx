<%@ Page Title="" Language="C#" MasterPageFile="~/YetkiliPanel.Master" AutoEventWireup="true" CodeBehind="KitapListesi.aspx.cs" Inherits="AspnetKütüphaneProjesi.KitapListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <title>Admin Paneli</title>
    <link href="../css/liste.css" rel="stylesheet" />
    <div style="margin-top: 8%; margin-left: 5%;">
        <h1>YETKİLİ İŞLEMLERİ</h1>
        <table id="myTable" class="table table-bordered">
            <thead>
                <tr>
                    <th>KİTAP İD</th>
                    <th>KİTAP ADI</th>
                    <th>KATEGORİ</th>
                    <th>YAZAR</th>
                    <th>SAYFA SAYISI</th>
                    <th>SİL</th>
                    <th>GÜNCELLE</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="kitap" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("id")%></td>
                            <td><%#Eval("kitapadı")%></td>
                            <td><%#Eval("kategorisi")%></td>
                            <td><%#Eval("yazarı")%></td>
                            <td><%#Eval("sayfasayısı")%></td>
                            <td>
                                <a class="btn btn-danger" href="KitapListesi.aspx?id=<%#Eval("id")%>&islem=sil">Sil</a>
                            </td>
                            <td>
                                <a class="btn btn-success" href="KitapGüncelle.aspx?id=<%#Eval("id")%>">Güncelle</a>

                            </td>

                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
