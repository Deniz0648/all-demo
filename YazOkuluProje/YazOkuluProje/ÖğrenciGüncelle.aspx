﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ÖğrenciGüncelle.aspx.cs" Inherits="YazOkuluProje.ÖğrenciGüncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">

        <div class="form-group">

            <div>
            <asp:Label for="TxtId" runat="server" Text="Öğrenci ID" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
            <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
            <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifresi" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

            <div>
            <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğrafı" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />

        <asp:Button ID="Button1" runat="server" Text="Güncelle" OnClick="Button1_Click" CssClass="btn btn-success" />
        </div>

    </form>
</asp:Content>