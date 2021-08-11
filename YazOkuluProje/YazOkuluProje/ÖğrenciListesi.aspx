<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ÖğrenciListesi.aspx.cs" Inherits="YazOkuluProje.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">

        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>

        </tr>
        <body>

         <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
            <tr>
                <td><%#Eval("ID")  %></td>
                <td><%#Eval("AD")  %></td>
                <td><%#Eval("SOYAD")  %></td>
                <td><%#Eval("NUMARA")  %></td>
                <td><%#Eval("SIFRE")  %></td>
                <td><%#Eval("FOTOGRAF")  %></td>
                <td><%#Eval("BAKİYE")  %></td>
                <td>
                    <asp:HyperLink NavigateUrl='<%# "~/ÖğrenciSil.aspx?ogrID="+Eval("ID")%>' CssClass="btn btn-danger" ID="HyperLink1"  runat="server" Text="Sil">Sil
                    </asp:HyperLink>
                    <asp:HyperLink NavigateUrl='<%# "~/ÖğrenciGüncelle.aspx?ogrID="+Eval("ID")%>' CssClass="btn btn-success" ID="HyperLink2" runat="server" Text="Güncelle">Güncelle
                    </asp:HyperLink>
                </td>
            </tr>

            </ItemTemplate>
            </asp:Repeater>
        </body>

    </table>

</asp:Content>