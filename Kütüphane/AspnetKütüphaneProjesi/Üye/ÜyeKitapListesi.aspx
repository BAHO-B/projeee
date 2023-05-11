<%@ Page Title="" Language="C#" MasterPageFile="~/ÜyePanel.Master" AutoEventWireup="true" CodeBehind="ÜyeKitapListesi.aspx.cs" Inherits="AspnetKütüphaneProjesi.ÜyeKitapListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/liste.css" rel="stylesheet" />
    <div style="font-size:18px; width:80%; margin-left:10%; margin-top:2%;">
        <table>
            <thead>
                <tr>
                    <th>KİTAP İD</th>
                    <th>KİTAP ADI</th>
                    <th>KATEGORİ</th>
                    <th>YAZAR</th>
                    <th>SAYFA SAYISI</th>
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
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
