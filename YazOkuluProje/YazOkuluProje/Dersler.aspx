<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkuluProje.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">



    <div>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
    <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
    </div>
    <br />

    <div>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Öğrenci ID"></asp:Label>
    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    <br />

    <asp:Button CssClass="btn btn-warning" ID="Button1" runat="server" Text="Ders Talep Oluştur" OnClick="Button1_Click" />



    </form>
</asp:Content>
